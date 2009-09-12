using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.ComponentModel;
using TUPUX.ActiveRecord;
using log4net;

namespace TUPUX.Entity
{
    #region Excel import

    /// <summary>
    /// Class for managing Excel files
    /// </summary>
    public class ExcelReader : IDisposable
    {
        #region Attributes and Properties

        private string _strExcelFilename;
        private bool _blnMixedData = true;
        private string _strSheetName;
        private string _strSheetRange;
        private bool _blnKeepConnectionOpen = false;
        private OleDbConnection _oleConn;
        private OleDbCommand _oleCmdSelect;
        private string where;

        public string Where
        {
            get { return where; }
            set { where = value; }
        }       

        public string ExcelFilename
        {
            get { return _strExcelFilename; }
            set { _strExcelFilename = value; }
        }

        public string SheetName
        {
            get { return _strSheetName; }
            set { _strSheetName = value; }
        }

        public string SheetRange
        {
            get { return _strSheetRange; }
            set
            {
                if (value.IndexOf(":") == -1) throw new Exception("Invalid range length");
                _strSheetRange = value;
            }
        }

        public bool KeepConnectionOpen
        {
            get { return _blnKeepConnectionOpen; }
            set { _blnKeepConnectionOpen = value; }
        }

        public bool MixedData
        {
            get { return _blnMixedData; }
            set { _blnMixedData = value; }
        }

        #endregion

        #region Methods

        #region Excel Connection

        /// <summary>
        /// Gets excel connection options
        /// </summary>
        /// <returns></returns>
        private string ExcelConnectionOptions()
        {
            string strOpts = "";
            if (this.MixedData == true)
                strOpts += "Imex=1;";
            return strOpts;

        }

        /// <summary>
        /// Gets connection excel string
        /// </summary>
        /// <returns></returns>
        private string ExcelConnection()
        {
            return
              @"Provider=Microsoft.Jet.OLEDB.4.0;" +
              @"Data Source=" + _strExcelFilename + ";" +
              @"Extended Properties=" + Convert.ToChar(34).ToString() +
              @"Excel 8.0;" + ExcelConnectionOptions() + Convert.ToChar(34).ToString();
        }

        #endregion

        #region Open / Close

        /// <summary>
        /// Opens connection
        /// </summary>
        public void Open()
        {
            try
            {
                if (_oleConn != null)
                {
                    if (_oleConn.State == ConnectionState.Open)
                    {
                        _oleConn.Close();
                    }
                    _oleConn = null;
                }

                if (System.IO.File.Exists(_strExcelFilename) == false)
                {
                    throw new Exception("Excel file " + _strExcelFilename + "could not be found.");
                }
                _oleConn = new OleDbConnection(ExcelConnection());
                _oleConn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Closes connection
        /// </summary>
        public void Close()
        {
            if (_oleConn != null)
            {
                if (_oleConn.State != ConnectionState.Closed)
                    _oleConn.Close();
                _oleConn.Dispose();
                _oleConn = null;
            }
        }

        #endregion

        #region Command Select

        private bool SetSheetQuerySelect()
        {
            try
            {
                if (_oleConn == null)
                {
                    throw new Exception("Connection is unassigned or closed.");
                }

                //if (_strSheetName.Length ==0)
                //  throw new Exception("Sheetname was not assigned."); 

                _oleCmdSelect = new OleDbCommand(@"SELECT * FROM [" + _strSheetName + "$", _oleConn);

                if (_strSheetName.Length != 0)
                    _oleCmdSelect.CommandText = _oleCmdSelect.CommandText + _strSheetRange;

                _oleCmdSelect.CommandText = _oleCmdSelect.CommandText + "]";

                if (!String.IsNullOrEmpty(where) && where.Trim() != String.Empty)
                {
                    _oleCmdSelect.CommandText = _oleCmdSelect.CommandText + "WHERE " + where;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        #endregion

        #region simple utilities

        /// <summary>
        /// Returns the column name
        /// </summary>
        /// <param name="intCol">Column position</param>
        /// <returns>Column name</returns>
        public string ColName(int intCol)
        {
            string sColName = "";
            if (intCol < 26)
                sColName = Convert.ToString(Convert.ToChar((Convert.ToByte((char)'A') + intCol)));
            else
            {
                int intFirst = ((int)intCol / 26);
                int intSecond = ((int)intCol % 26);
                sColName = Convert.ToString(Convert.ToByte((char)'A') + intFirst);
                sColName += Convert.ToString(Convert.ToByte((char)'A') + intSecond);
            }
            return sColName;
        }

        /// <summary>
        /// Gets the column number
        /// </summary>
        /// <param name="strCol">Column name</param>
        /// <returns>Column number</returns>
        public int ColNumber(string strCol)
        {
            strCol = strCol.ToUpper();
            int intColNumber = 0;
            if (strCol.Length > 1)
            {
                intColNumber = Convert.ToInt16(Convert.ToByte(strCol[1]) - 65);
                intColNumber += Convert.ToInt16(Convert.ToByte(strCol[1]) - 64) * 26;
            }
            else
                intColNumber = Convert.ToInt16(Convert.ToByte(strCol[0]) - 65);
            return intColNumber;
        }

        /// <summary>
        /// Gets list of the excel sheet names
        /// </summary>
        /// <returns>Names</returns>
        public String[] GetExcelSheetNames()
        {
            System.Data.DataTable dt = null;

            try
            {
                if (_oleConn == null) Open();

                // Get the data table containing the schema
                dt = _oleConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                if (dt == null)
                {
                    return null;
                }

                String[] excelSheets = new String[dt.Rows.Count];
                int i = 0;

                // Add the sheet name to the string array.
                foreach (DataRow row in dt.Rows)
                {
                    string strSheetTableName = row["TABLE_NAME"].ToString();
                    excelSheets[i] = strSheetTableName.Substring(0, strSheetTableName.Length - 1);
                    i++;
                }


                return excelSheets;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                // Clean up.
                if (this.KeepConnectionOpen == false)
                {
                    this.Close();
                }
                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }
            }
        }


        private string AddWithComma(string strSource, string strAdd)
        {
            if (strSource != "") strSource = strSource += ", ";
            return strSource + strAdd;
        }

        private string AddWithAnd(string strSource, string strAdd)
        {
            if (strSource != "") strSource = strSource += " and ";
            return strSource + strAdd;
        }

        #endregion

        public DataTable GetTable()
        {
            return GetTable("ExcelTable");
        }

        public DataTable GetTable(string strTableName)
        {
            try
            {
                //Open and query
                if (_oleConn == null) Open();
                if (_oleConn.State != ConnectionState.Open)
                    throw new Exception("Connection cannot open error.");
                if (SetSheetQuerySelect() == false) return null;

                //Fill table
                OleDbDataAdapter oleAdapter = new OleDbDataAdapter();
                oleAdapter.SelectCommand = _oleCmdSelect;
                DataTable dt = new DataTable(strTableName);
                oleAdapter.FillSchema(dt, SchemaType.Source);
                oleAdapter.Fill(dt);

                //SetPrimaryKey(dt);
                //Cannot delete rows in Excel workbook
                dt.DefaultView.AllowDelete = false;

                //Clean up
                _oleCmdSelect.Dispose();
                _oleCmdSelect = null;
                oleAdapter.Dispose();
                oleAdapter = null;
                if (KeepConnectionOpen == false) Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetDataTable(DataTable dt)
        {
            try
            {
                //Open and query
                if (_oleConn == null) Open();
                if (_oleConn.State != ConnectionState.Open)
                    throw new Exception("Connection cannot open error.");
                if (SetSheetQuerySelect() == false) return null;

                ////Fill table
                OleDbDataAdapter oleAdapter = new OleDbDataAdapter();
                oleAdapter.SelectCommand = _oleCmdSelect;

                //oleAdapter.FillSchema(ds, SchemaType.Source);
                oleAdapter.Fill(dt);


                //Clean up
                _oleCmdSelect.Dispose();
                _oleCmdSelect = null;
                oleAdapter.Dispose();
                oleAdapter = null;
                if (KeepConnectionOpen == false) Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Dispose / Destructor

        public void Dispose()
        {
            if (_oleConn != null)
            {
                _oleConn.Dispose();
                _oleConn = null;
            }
            if (_oleCmdSelect != null)
            {
                _oleCmdSelect.Dispose();
                _oleCmdSelect = null;
            }
            // Dispose of remaining objects.
        }

        #endregion

        #region CTOR

        public ExcelReader()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #endregion
    }

    /// <summary>
    /// Class for the import of models of a file excel
    /// </summary>
    public class HelperImport
    {
        #region CTOR

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="appPath">Application Path</param>
        /// <param name="fileName">File name</param>
        public HelperImport(string fileName)
        {            
            _fileName = fileName;
            _models = project.GetUMLModels();
            _scenariosModel = _models.Find(FindScenarios);
            _iterationModel = _models.Find(FindLogicalView);
            _designModel = _models.Find(FindDesignView);
        }

        #endregion

        #region Properties and fields

        private string _fileName = "";

        private UMLPhaseCollection _phases;

        private UMLPhaseCollection Phases
        {
            get { return _phases; }
            set { _phases = value; }
        }

        private UMLIterationCollection _iterations;

        private UMLIterationCollection Iterations
        {
            get { return _iterations; }
            set { _iterations = value; }
        }

        private UMLUseCaseCollection _useCases;

        private UMLUseCaseCollection UseCases
        {
            get { return _useCases; }
            set { _useCases = value; }
        }

        private UMLCollaborationCollection _collaborations;

        private UMLCollaborationCollection Collaborations
        {
            get { return _collaborations; }
            set { _collaborations = value; }
        }

        private UMLFileCollection _files;

        private UMLFileCollection Files
        {
            get { return _files; }
            set { _files = value; }
        }

        private UMLPackageCollection _packages;

        public UMLPackageCollection Packages
        {
            get { return _packages; }
            set { _packages = value; }
        }

        private UMLProject project = Helper.GetProject<UMLProject>();

        private UMLModelCollection _models;

        private UMLModel _scenariosModel;

        private UMLModel _iterationModel;

        private UMLModel _designModel;

        private BackgroundWorker bwAsync = null;

        private int totalProcess = 1;

        private int currentProcess = 0;

        private static readonly ILog log = LogManager.GetLogger(typeof(HelperImport));

        #endregion

        #region Constants

        private const string PHASE_SHEET = "Iteration";
        private const string COLLABORATION_SHEET = "Collaboration";
        private const string FILE_SHEET = "File";

        private const string pathImportDiagramCollaborationFile = @"\default\fragments\Collaboration-Files.mfg";
        private const string pathImportDiagramIterationPhase = @"\default\fragments\Iteration-Phases.mfg";

        private const string diagramCollaborationFileName = "CollagorationFilesDiagram";
        private const string diagramIterationPhaseName = "IterationPhaseDiagram";

        #endregion

        #region Methods

        /// <summary>
        /// Adds message to the background worker
        /// </summary>
        /// <param name="percentage">Percentage</param>
        /// <param name="message">Message</param>
        private void addMessageBackgroundWorker(int percentage, string message)
        {
            if (bwAsync != null)
            {
                bwAsync.ReportProgress(percentage, message);
            }
        }

        /// <summary>
        /// Gets a model from a excel file 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Import(object sender, DoWorkEventArgs e)
        {
            try
            {
                bwAsync = sender as BackgroundWorker;
                InitCollections();
                LoadDataExcel();
                if (ValidateData())
                {
                    SaveImport();
                }
                e.Result = genereteResumen();
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }

        /// <summary>
        /// Initializes collections
        /// </summary>
        private void InitCollections()
        {
            addMessageBackgroundWorker(0, "Init import...");
            Phases = new UMLPhaseCollection();
            Iterations = new UMLIterationCollection();
            Files = new UMLFileCollection();
            UseCases = new UMLUseCaseCollection();
            Collaborations = new UMLCollaborationCollection();
            Packages= new UMLPackageCollection();
        }

        /// <summary>
        /// Finds model with name "Use Case Model"
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private bool FindScenarios(UMLModel model)
        {
            //if (model.Name == "Scenarios")
            if (model.Name == "Use Case Model")
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Finds model with name "Phase Iteration Model"
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private bool FindLogicalView(UMLModel model)
        {
            //if (model.Name == "Logical View")
            if (model.Name == "Phase Iteration Model")
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// Finds model with name "Design Model"
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private bool FindDesignView(UMLModel model)
        {
            //if (model.Name == "Logical View")
            if (model.Name == "Design Model")
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Gets resumen of the importation
        /// </summary>
        /// <returns></returns>
        private string genereteResumen()
        {
            string resumen = "Resumen\n\n";
            resumen += "Phases :\t\t\t" + Phases.Count + "\n";
            resumen += "Iterations :\t\t" + Iterations.Count + "\n";
            resumen += "UseCases :\t\t" + UseCases.Count + "\n";
            resumen += "Collborations :\t\t" + Collaborations.Count + "\n";
            resumen += "Files :\t\t\t" + Files.Count + "\n";
            return resumen;
        }

        #region Save Data

        /// <summary>
        /// Saves all elements in the StarUML application
        /// </summary>
        public void SaveImport()
        {
            addMessageBackgroundWorker(0, "Start create elements...");
            Helper.BeginUpdate();
            Packages.SaveAll();
            SaveFiles();
            SavePhases();
            SaveIterations();
            SaveUseCases();
            SaveCollaborations();
            CreateDiagrams();
            Helper.EndUpdate();
            addMessageBackgroundWorker(100, "End create elements...");
        }

        /// <summary>
        /// Saves list of collaborations
        /// </summary>
        private void SaveCollaborations()
        {
            try
            {
                foreach (UMLCollaboration collaboration in Collaborations)
                {
                    addMessageBackgroundWorker((100 * currentProcess++) / totalProcess, "Creating Collaboration: " + collaboration.Name);
                    if (String.IsNullOrEmpty(collaboration.Guid))
                    {
                        collaboration.SaveImport();
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }

        /// <summary>
        /// Saves list of use cases
        /// </summary>
        private void SaveUseCases()
        {
            try
            {
                foreach (UMLUseCase usecase in UseCases)
                {
                    addMessageBackgroundWorker((100 * currentProcess++) / totalProcess, "Creating UseCase: " + usecase.Name);
                    if (String.IsNullOrEmpty(usecase.Guid))
                    {
                        usecase.SaveImport();
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }

        /// <summary>
        /// Saves list of iterations
        /// </summary>
        private void SaveIterations()
        {
            try
            {
                foreach (UMLIteration iteration in Iterations)
                {
                    addMessageBackgroundWorker((100 * currentProcess++) / totalProcess, "Creating Iteration: " + iteration.Name);
                    if (String.IsNullOrEmpty(iteration.Guid))
                    {
                        iteration.SaveImport();
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }

        /// <summary>
        /// Saves list of phases
        /// </summary>
        private void SavePhases()
        {
            try
            {
                foreach (UMLPhase phase in Phases)
                {
                    addMessageBackgroundWorker((100 * currentProcess++) / totalProcess, "Creating Phase: " + phase.Name);
                    phase.SaveImport();
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }
        
        /// <summary>
        /// Saves list of files
        /// </summary>
        private void SaveFiles()
        {
            try
            {
                foreach (UMLFile file in Files)
                {
                    addMessageBackgroundWorker((100 * currentProcess++) / totalProcess, "Creating File: " + file.Name);
                    file.SaveImport();
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }

        /// <summary>
        /// Creates Diagrams
        /// </summary>
        private void CreateDiagrams()
        {
            try
            {
                addMessageBackgroundWorker(100, "Creating Diagram Collaboration-Files...");

                Helper.CreateDiagramCollaborationFiles<UMLCollaborationCollection, UMLCollaboration, UMLFileCollection, UMLFile>(_scenariosModel, Collaborations, Files, Constants.AppPath.Path + pathImportDiagramCollaborationFile, diagramCollaborationFileName);

                addMessageBackgroundWorker(100, "Creating Diagram Iteration-Phase...");
                Helper.CreateDiagramPhaseIteration<UMLPhaseCollection, UMLPhase, UMLIterationCollection, UMLIteration>(_iterationModel, Phases, Iterations, Constants.AppPath.Path + pathImportDiagramIterationPhase, diagramIterationPhaseName);
                addMessageBackgroundWorker(100, "Diagram Iteration-Phase created...");
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }

        #endregion

        #region Load Data

        /// <summary>
        /// Loads collections
        /// </summary>
        private void LoadDataExcel()
        {
            addMessageBackgroundWorker(0, "Reading excel...");
            LoadPhasesIterationsExcel();
            LoadUseCasesCollaborationsExcel();
            LoadFilesExcel();
            totalProcess = Phases.Count + Iterations.Count + Files.Count + UseCases.Count + Collaborations.Count;
            addMessageBackgroundWorker(0, "End read excel...");
        }

        /// <summary>
        /// Loads the iterations and phases
        /// </summary>
        public void LoadPhasesIterationsExcel()
        {
            DataTable dtResult = new DataTable();
            dtResult = GetDataTable(_fileName, PHASE_SHEET, "Phase <> ''");
            UMLPackage pack = new UMLPackage();
            pack.Name = "IterationsFaseImport";
            pack.Owner = _iterationModel;

            Packages.Add(pack);
            foreach (DataRow dr in dtResult.Rows)
            {
                UMLPhase phase = new UMLPhase();
                phase.Name = dr["Phase"].ToString().Trim();
                phase.Owner = pack;
                phase = AddPhase(phase);

                UMLIteration iteration = new UMLIteration();
                iteration.Name = dr["Name"].ToString().Trim();
                string[] usecasesName = dr["UseCaseList"].ToString().Split(',');
                foreach (string useCaseName in usecasesName)
                {
                    UMLUseCase useCase = new UMLUseCase();
                    useCase.Name = useCaseName.Trim();
                    useCase = AddUseCase(useCase);
                    iteration.UseCases.Add(useCase);
                }

                //iteration.Owner = _logical;
                iteration.Owner = phase;
                iteration = AddIteration(iteration);
                iteration.Prev = getIterationByName(dr["Prev"].ToString());
                phase.Iterations.Add(iteration);
            }
        }

        /// <summary>
        /// Adds a new phase
        /// </summary>
        /// <param name="phase"></param>
        /// <returns></returns>
        private UMLPhase AddPhase(UMLPhase phase)
        {
            foreach (UMLPhase p in Phases)
            {
                if (phase.Name == p.Name)
                    return p;
            }
            phase.Stereotype = Constants.UMLPhase.STEREOTYPE;
            Phases.Add(phase);
            return phase;
        }

        /// <summary>
        /// Adds a new iteration
        /// </summary>
        /// <param name="iteration"></param>
        /// <returns></returns>
        private UMLIteration AddIteration(UMLIteration iteration)
        {
            foreach (UMLIteration i in Iterations)
            {
                if (iteration.Name == i.Name)
                {
                    i.Owner = iteration.Owner;
                    i.UseCases = iteration.UseCases;
                    return i;
                }
            }
            iteration.Stereotype = Constants.UMLIteration.STEREOTYPE;
            Iterations.Add(iteration);
            return iteration;
        }

        /// <summary>
        /// Gets a iteration by name
        /// </summary>
        /// <param name="name">iteration name</param>
        /// <returns></returns>
        private UMLIteration getIterationByName(string name)
        {
            foreach (UMLIteration iteration in Iterations)
            {
                if (name == iteration.Name)
                {
                    return iteration;
                }
            }
            return null;
        }

        /// <summary>
        /// Loads the use cases and collaborations
        /// </summary>
        public void LoadUseCasesCollaborationsExcel()
        {
            DataTable dtResult = new DataTable();
            dtResult = GetDataTable(_fileName, COLLABORATION_SHEET, "Name <> ''");

            UMLPackage pack = new UMLPackage();
            pack.Name = "UseCaseImport";
            pack.Owner = _scenariosModel;
            Packages.Add(pack);

            foreach (DataRow dr in dtResult.Rows)
            {
                UMLUseCase useCase = new UMLUseCase();
                useCase.Name = dr["UseCase"].ToString().Trim();
                useCase.Owner = pack;
                useCase = AddUseCase(useCase);

                UMLCollaboration collaboration = new UMLCollaboration();
                collaboration.Name = dr["Name"].ToString().Trim();
                collaboration.Type = dr["Type"].ToString();

                if (dr["SendMessage"].ToString() == "X")
                {
                    collaboration.SendMessage = true;
                }

                if (dr["GenerateAction"].ToString() == "X")
                {
                    collaboration.GenerateAction = true;
                }

                string[] filesName = dr["FilesList"].ToString().Split(',');
                foreach (string fName in filesName)
                {
                    UMLFile file = new UMLFile();
                    file.Name = fName.Trim();
                    file = AddFile(file);
                    collaboration.Files.Add(file);
                }

                collaboration.Owner = useCase;
                collaboration = AddCollaboration(collaboration);
                useCase.Collaborations.Add(collaboration);
            }
        }

        /// <summary>
        /// Adds a new use case
        /// </summary>
        /// <param name="useCase"></param>
        /// <returns></returns>
        private UMLUseCase AddUseCase(UMLUseCase useCase)
        {
            foreach (UMLUseCase u in UseCases)
            {
                //if (useCase.Name == u.Name && useCase.Owner == u.Owner)
                if (useCase.Name == u.Name)
                {
                    u.Owner = useCase.Owner;
                    u.Collaborations = useCase.Collaborations;
                    return u;
                }
            }
            UseCases.Add(useCase);
            return useCase;
        }

        /// <summary>
        /// Adds a new collaboration
        /// </summary>
        /// <param name="collaboration"></param>
        /// <returns></returns>
        private UMLCollaboration AddCollaboration(UMLCollaboration collaboration)
        {
            foreach (UMLCollaboration c in Collaborations)
            {
                if (collaboration.Name == c.Name && collaboration.Owner == c.Owner)
                {
                    c.Files = collaboration.Files;
                    return c;
                }
            }
            Collaborations.Add(collaboration);
            return collaboration;
        }

        /// <summary>
        /// Loads the files
        /// </summary>
        public void LoadFilesExcel()
        {
            DataTable dtResult = new DataTable();
            dtResult = GetDataTable(_fileName, FILE_SHEET, "Name <> '' AND AttributesList <> ''");

            UMLPackage pack = new UMLPackage();
            pack.Name = "FileImport";
            pack.Owner = _designModel;
            Packages.Add(pack);

            foreach (DataRow dr in dtResult.Rows)
            {
                UMLFile file = new UMLFile();
                file.Name = dr["Name"].ToString().Trim();
                string test = file.Name.GetType().Name;
                file.Dets = Convert.ToInt32(dr["Dets"].ToString());
                file.Rets = Convert.ToInt32(dr["Rets"].ToString());
                file.Type = dr["Type"].ToString();
                file.Owner = pack;

                string[] attributes = dr["AttributesList"].ToString().Split(',');
                foreach (string a in attributes)
                {
                    UMLAttribute attri = new UMLAttribute();
                    attri.Name = a.Trim();
                    attri.Owner = file;
                    file.Attributes.Add(attri);
                }
                AddFile(file);
            }
        }

        /// <summary>
        /// Adds a new file
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private UMLFile AddFile(UMLFile file)
        {
            file.Stereotype = Constants.UMLFile.STEREOTYPE;
            foreach (UMLFile f in Files)
            {
                if (file.Name == f.Name)
                {
                    f.Dets = file.Dets;
                    f.Rets = file.Rets;
                    f.Type = file.Type;
                    f.Attributes = file.Attributes;
                    f.Owner = file.Owner;
                    f.Stereotype = file.Stereotype;
                    return f;
                }
            }

            Files.Add(file);
            return file;
        }

        /// <summary>
        /// Gets data table from a excel sheet
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <param name="sheet">Sheet</param>
        /// <param name="where">Condition</param>
        /// <returns></returns>
        private DataTable GetDataTable(string fileName, string sheet, string where)
        {
            DataTable dtResult = new DataTable();
            ExcelReader excelReader = new ExcelReader();
            excelReader.ExcelFilename = fileName;
            excelReader.SheetName = sheet;
            excelReader.KeepConnectionOpen = true;
            excelReader.Where = where;
            excelReader.Open();

            excelReader.GetDataTable(dtResult);
            excelReader.Close();
            return dtResult;
        }

        #endregion

        #region Validate Data Loaded

        /// <summary>
        /// Validates all collections
        /// </summary>
        /// <returns></returns>
        public bool ValidateData()
        {
            addMessageBackgroundWorker(0, "Validating...");
            bool vphases = ValidatePhases();
            bool viterations = ValidateIterations();
            bool vusecases = ValidateUseCases();
            bool vfiles = ValidateFiles();
            addMessageBackgroundWorker(0, "Validated...");
            return vphases & viterations & vusecases & vfiles;
        }

        /// <summary>
        /// Validates the files
        /// </summary>
        /// <returns></returns>
        private bool ValidateFiles()
        {
            foreach (UMLFile file in Files)
            {
                if (file.Owner == null) return false;
                int count = 0;
                foreach (UMLFile f in Files)
                {
                    if (file.Name == f.Name)
                    {
                        count++;
                    }
                }
                if (count > 1) return false;
            }

            return true;
        }

        /// <summary>
        /// Validates the use cases
        /// </summary>
        /// <returns></returns>
        private bool ValidateUseCases()
        {
            foreach (UMLUseCase u in UseCases)
            {
                if (u.Owner == null) return false;
                int count = 0;
                foreach (UMLUseCase u2 in UseCases)
                {
                    if (u.Name == u2.Name)
                    {
                        count++;
                    }
                }
                if (count > 1) return false;
            }
            return true;
        }

        /// <summary>
        /// Validates the iterations
        /// </summary>
        /// <returns></returns>
        private bool ValidateIterations()
        {
            foreach (UMLIteration i in Iterations)
            {
                if (i.Owner == null) return false;
                int count = 0;
                foreach (UMLIteration i2 in Iterations)
                {
                    if (i.Name == i2.Name)
                    {
                        count++;
                    }
                }
                if (count > 1) return false;
            }
            return true;
        }

        /// <summary>
        /// Validates the phases
        /// </summary>
        /// <returns></returns>
        private bool ValidatePhases()
        {
            foreach (UMLPhase p in Phases)
            {
                if (p.Owner == null) return false;
                int count = 0;
                foreach (UMLPhase p2 in Phases)
                {
                    if (p.Name == p2.Name)
                    {
                        count++;
                    }
                }
                if (count > 1) return false;
            }
            return true;
        }

        #endregion

        #endregion
    }

    #endregion
}
