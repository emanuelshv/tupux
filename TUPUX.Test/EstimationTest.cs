using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TUPUX.Entity;
using TUPUX.ActiveRecord;
using System.IO;
using System.Windows.Forms;

namespace TUPUX.Test
{
    [TestFixture]
    public class EstimationTest
    {

        private void FileReturnNothing(int dets, int rets, string type)
        {

            double result = 0;
            if (UMLFileType.ILF == type)
            {
                result = HelperEstimation.CalculateFileFunctionPoints(UMLFileType.ILF, dets, rets);                
                Assert.AreEqual(result, 0);
                Assert.AreNotEqual(result, 7);
                Assert.AreNotEqual(result, 10);
                Assert.AreNotEqual(result, 15);
            }
            else if (UMLFileType.EIF == type)
            {
                result = HelperEstimation.CalculateFileFunctionPoints(UMLFileType.EIF, dets, rets);
                Assert.AreEqual(result, 0);
                Assert.AreNotEqual(result, 5);
                Assert.AreNotEqual(result, 7);
                Assert.AreNotEqual(result, 10);
            }
            //System.Console.WriteLine(String.Format("Eval -- > Dets:{0}, Rets:{1} - result:{2}", dets, rets, result));
        }

        private void FileReturnLow(int dets, int rets, string type)
        {
            double result = 0;
            if (UMLFileType.ILF == type)
            {
                result = HelperEstimation.CalculateFileFunctionPoints(UMLFileType.ILF, dets, rets);
                Assert.AreNotEqual(0, result);
                Assert.AreEqual(7, result);
                Assert.AreNotEqual(10, result);
                Assert.AreNotEqual(15, result);
            }
            else if (UMLFileType.EIF == type)
            {
                result = HelperEstimation.CalculateFileFunctionPoints(UMLFileType.EIF, dets, rets);
                Assert.AreNotEqual(0, result);
                Assert.AreEqual(5, result);
                Assert.AreNotEqual(7, result);
                Assert.AreNotEqual(10, result);
            }
            //System.Console.WriteLine(String.Format("Eval -- > Dets:{0}, Rets:{1} - result:{2}", dets, rets, result));
        }

        private void FileReturnAvarage(int dets, int rets, string type)
        {
            double result = 0;
            if (UMLFileType.ILF == type)
            {
                result = HelperEstimation.CalculateFileFunctionPoints(UMLFileType.ILF, dets, rets);
                Assert.AreNotEqual(0, result);
                Assert.AreNotEqual(7, result);
                Assert.AreEqual(10, result);
                Assert.AreNotEqual(15, result);
            }
            else if (UMLFileType.EIF == type)
            {
                result = HelperEstimation.CalculateFileFunctionPoints(UMLFileType.EIF, dets, rets);
                Assert.AreNotEqual(0, result);
                Assert.AreNotEqual(5, result);
                Assert.AreEqual(7, result);
                Assert.AreNotEqual(10, result);
            }
            //System.Console.WriteLine(String.Format("Eval -- > Dets:{0}, Rets:{1} - result:{2}", dets, rets, result));
        }

        private void FileReturnHigh(int dets, int rets, string type)
        {
            double result = 0;
            if (UMLFileType.ILF == type)
            {
                result = HelperEstimation.CalculateFileFunctionPoints(UMLFileType.ILF, dets, rets);
                Assert.AreNotEqual(0, result);
                Assert.AreNotEqual(7, result);
                Assert.AreNotEqual(10, result);
                Assert.AreEqual(15, result);
            }
            else if (UMLFileType.EIF == type)
            {
                result = HelperEstimation.CalculateFileFunctionPoints(UMLFileType.EIF, dets, rets);
                Assert.AreNotEqual(0, result);
                Assert.AreNotEqual(5, result);
                Assert.AreNotEqual(7, result);
                Assert.AreEqual(10, result);
            }
            //System.Console.WriteLine(String.Format("Eval -- > Dets:{0}, Rets:{1} - result:{2}", dets, rets, result));
        }

        [Test]
        public void TestCalulateFileFunctionPoints_ILF()
        {

            /// 
            /// Test with:
            /// FileType : ILF
            /// rets : -25, 0
            /// dets : 
            ///     -100 ... 55 return 0
            /// 
            for (int i = -25; i < 0; i++)
            {

                for (int j = -100; j < 55; j++)
                {
                    FileReturnNothing(j, i, UMLFileType.ILF);
                }
            }


            /// 
            /// Test with:
            /// FileType : ILF
            /// rets : 1
            /// dets : 
            ///     -100 ... 0 return 0
            ///     1  ... 19 return (Low)7 
            ///     20 ... 50 return (Low)7
            ///     51 ... more return (Avarage)10
            ///     
            for (int j = -100; j < 1; j++)
            {
                FileReturnNothing(j, 1, UMLFileType.ILF);
            }
            for (int j = 1; j < 20; j++)
            {
                FileReturnLow(j, 1, UMLFileType.ILF);
            }

            for (int j = 20; j < 50; j++)
            {
                FileReturnLow(j, 1, UMLFileType.ILF);
            }

            for (int j = 51; j < 100; j++)
            {
                FileReturnAvarage(j, 1, UMLFileType.ILF);
            }

            /// 
            /// Test with:
            /// FileType : ILF
            /// rets : 2...5            
            /// dets : 
            ///     -100 ... 0 return 0
            ///     1  ... 19 return (Low)7 
            ///     20 ... 50 return (Avarage)10
            ///     51 ... more return (High)15
            ///  
            for (int i = 2; i < 6; i++)
            {
                for (int j = -100; j < 1; j++)
                {
                    FileReturnNothing(j, i, UMLFileType.ILF);
                }

                for (int j = 1; j < 20; j++)
                {
                    FileReturnLow(j, i, UMLFileType.ILF);
                }

                for (int j = 20; j < 50; j++)
                {
                    FileReturnAvarage(j, i, UMLFileType.ILF);
                }

                for (int j = 51; j < 100; j++)
                {
                    FileReturnHigh(j, i, UMLFileType.ILF);
                }
            }

            /// 
            /// Test with:
            /// FileType : ILF
            /// rets : 6...100           
            ///     -100 ... 0 return 0
            ///     1  ... 19 return (Avarage)10 
            ///     20 ... 50 return (High)15
            ///     51 ... more return (High)15
            ///
            for (int i = 6; i < 101; i++)
            {
                for (int j = -100; j < 1; j++)
                {
                    FileReturnNothing(j, i, UMLFileType.ILF);
                }
                for (int j = 1; j < 20; j++)
                {
                    FileReturnAvarage(j, i, UMLFileType.ILF);
                }

                for (int j = 20; j < 50; j++)
                {
                    FileReturnHigh(j, i, UMLFileType.ILF);
                }

                for (int j = 51; j < 100; j++)
                {
                    FileReturnHigh(j, i, UMLFileType.ILF);
                }
            }
        }

        [Test]
        public void TestCalulateFileFunctionPoints_EIF()
        {

            /// 
            /// Test with:
            /// FileType : EIF
            /// rets : -25, 0
            /// dets : 
            ///     -100 ... 55 return 0
            /// 
            for (int i = -25; i < 0; i++)
            {

                for (int j = -100; j < 55; j++)
                {
                    FileReturnNothing(j, i, UMLFileType.EIF);
                }
            }


            /// 
            /// Test with:
            /// FileType : EIF
            /// rets : 1
            /// dets : 
            ///     -100 ... 0 return 0
            ///     1  ... 19 return (Low)5 
            ///     20 ... 50 return (Low)5
            ///     51 ... more return (Avarage)7
            ///     
            for (int j = -100; j < 1; j++)
            {
                FileReturnNothing(j, 1, UMLFileType.EIF);
            }
            for (int j = 1; j < 20; j++)
            {
                FileReturnLow(j, 1, UMLFileType.EIF);
            }

            for (int j = 20; j < 50; j++)
            {
                FileReturnLow(j, 1, UMLFileType.EIF);
            }

            for (int j = 51; j < 100; j++)
            {
                FileReturnAvarage(j, 1, UMLFileType.EIF);
            }

            /// 
            /// Test with:
            /// FileType : EIF
            /// rets : 2...5            
            /// dets : 
            ///     -100 ... 0 return 0
            ///     1  ... 19 return (Low)5 
            ///     20 ... 50 return (Avarage)7
            ///     51 ... more return (High)10
            ///  
            for (int i = 2; i < 6; i++)
            {
                for (int j = -100; j < 1; j++)
                {
                    FileReturnNothing(j, i, UMLFileType.EIF);
                }

                for (int j = 1; j < 20; j++)
                {
                    FileReturnLow(j, i, UMLFileType.EIF);
                }

                for (int j = 20; j < 50; j++)
                {
                    FileReturnAvarage(j, i, UMLFileType.EIF);
                }

                for (int j = 51; j < 100; j++)
                {
                    FileReturnHigh(j, i, UMLFileType.EIF);
                }
            }

            /// 
            /// Test with:
            /// FileType : EIF
            /// rets : 6...100           
            ///     -100 ... 0 return 0
            ///     1  ... 19 return (Avarage)7 
            ///     20 ... 50 return (High)10
            ///     51 ... more return (High)10
            ///
            for (int i = 6; i < 101; i++)
            {
                for (int j = -100; j < 1; j++)
                {
                    FileReturnNothing(j, i, UMLFileType.EIF);
                }
                for (int j = 1; j < 20; j++)
                {
                    FileReturnAvarage(j, i, UMLFileType.EIF);
                }

                for (int j = 20; j < 50; j++)
                {
                    FileReturnHigh(j, i, UMLFileType.EIF);
                }

                for (int j = 51; j < 100; j++)
                {
                    FileReturnHigh(j, i, UMLFileType.EIF);
                }
            }
        }
        
        private void ActionReturnNothing(int dets, int ftrs, string type)
        {

            double result = 0;
            if (UMLActionType.EI == type)
            {
                result = HelperEstimation.CalculateActionFunctionPoints(UMLActionType.EI, dets, ftrs);
                Assert.AreEqual(0, result);
                Assert.AreNotEqual(3, result);
                Assert.AreNotEqual(4, result);
                Assert.AreNotEqual(6, result);
            }
            else if (UMLActionType.EQ == type)
            {
                result = HelperEstimation.CalculateActionFunctionPoints(UMLActionType.EQ, dets, ftrs);
                Assert.AreEqual(0, result);
                Assert.AreNotEqual(3, result);
                Assert.AreNotEqual(4, result);
                Assert.AreNotEqual(6, result);
            }

            else if (UMLActionType.EO == type)
            {
                result = HelperEstimation.CalculateActionFunctionPoints(UMLActionType.EO, dets, ftrs);
                Assert.AreEqual(0, result);
                Assert.AreNotEqual(4, result);
                Assert.AreNotEqual(5, result);
                Assert.AreNotEqual(7, result);
            }
            //System.Console.WriteLine(String.Format("Eval -- > Dets:{0}, Ftrs:{1} - result:{2}", dets, ftrs, result));
        }
        
        private void ActionReturnLow(int dets, int ftrs, string type)
        {

            double result = 0;
            if (UMLActionType.EI == type)
            {
                result = HelperEstimation.CalculateActionFunctionPoints(UMLActionType.EI, dets, ftrs);
                Assert.AreNotEqual(0, result);
                Assert.AreEqual(3, result);
                Assert.AreNotEqual(4, result);
                Assert.AreNotEqual(6, result);
            }
            else if (UMLActionType.EQ == type)
            {
                result = HelperEstimation.CalculateActionFunctionPoints(UMLActionType.EQ, dets, ftrs);
                Assert.AreNotEqual(0, result);
                Assert.AreEqual(3, result);
                Assert.AreNotEqual(4, result);
                Assert.AreNotEqual(6, result);
            }

            else if (UMLActionType.EO == type)
            {
                result = HelperEstimation.CalculateActionFunctionPoints(UMLActionType.EO, dets, ftrs);
                Assert.AreNotEqual(0, result);
                Assert.AreEqual(4, result);
                Assert.AreNotEqual(5, result);
                Assert.AreNotEqual(7, result);
            }
            //System.Console.WriteLine(String.Format("Eval -- > Dets:{0}, Ftrs:{1} - result:{2}", dets, ftrs, result));
        }
        
        private void ActionReturnAvarage(int dets, int ftrs, string type)
        {

            double result = 0;
            if (UMLActionType.EI == type)
            {
                result = HelperEstimation.CalculateActionFunctionPoints(UMLActionType.EI, dets, ftrs);
                Assert.AreNotEqual(0, result);
                Assert.AreNotEqual(3, result);
                Assert.AreEqual(4, result);
                Assert.AreNotEqual(6, result);
            }
            else if (UMLActionType.EQ == type)
            {
                result = HelperEstimation.CalculateActionFunctionPoints(UMLActionType.EQ, dets, ftrs);
                Assert.AreNotEqual(0, result);
                Assert.AreNotEqual(3, result);
                Assert.AreEqual(4, result);
                Assert.AreNotEqual(6, result);
            }

            else if (UMLActionType.EO == type)
            {
                result = HelperEstimation.CalculateActionFunctionPoints(UMLActionType.EO, dets, ftrs);
                Assert.AreNotEqual(0, result);
                Assert.AreNotEqual(4, result);
                Assert.AreEqual(5, result);
                Assert.AreNotEqual(7, result);
            }
            //System.Console.WriteLine(String.Format("Eval -- > Dets:{0}, Ftrs:{1} - result:{2}", dets, ftrs, result));
        }

        private void ActionReturnHigh(int dets, int ftrs, string type)
        {

            double result = 0;
            if (UMLActionType.EI == type)
            {
                result = HelperEstimation.CalculateActionFunctionPoints(UMLActionType.EI, dets, ftrs);
                Assert.AreNotEqual(0, result);
                Assert.AreNotEqual(3, result);
                Assert.AreNotEqual(4, result);
                Assert.AreEqual(6, result);
            }
            else if (UMLActionType.EQ == type)
            {
                result = HelperEstimation.CalculateActionFunctionPoints(UMLActionType.EQ, dets, ftrs);
                Assert.AreNotEqual(0, result);
                Assert.AreNotEqual(3, result);
                Assert.AreNotEqual(4, result);
                Assert.AreEqual(6, result);
            }

            else if (UMLActionType.EO == type)
            {
                result = HelperEstimation.CalculateActionFunctionPoints(UMLActionType.EO, dets, ftrs);
                Assert.AreNotEqual(0, result);
                Assert.AreNotEqual(4, result);
                Assert.AreNotEqual(5, result);
                Assert.AreEqual(7, result);
            }
            //System.Console.WriteLine(String.Format("Eval -- > Dets:{0}, Ftrs:{1} - result:{2}", dets, ftrs, result));
        }
        
        [Test]
        public void TestCalulateActionFunctionPoints_EI()
        {
            /// 
            /// Test with:
            /// ActionType : EI
            /// ftrs : -25...-1
            ///     -100 ... 55 return 0
            ///
            for (int i = -25; i < -1; i++)
            {
                for (int j = -100; j < 55; j++)
                {
                    ActionReturnNothing(j, i, UMLActionType.EI);
                }
            }


            /// 
            /// Test with:
            /// ActionType : EI
            /// ftrs : 0, 1
            ///     -100 ... 0 return 0
            ///     0 ... 4 return 3
            ///     5 ... 15 return 3
            ///     16 ... 55 return 4
            for (int i = 0; i < 2; i++)
            {
                for (int j = -100; j < 0; j++)
                {
                    ActionReturnNothing(j, i, UMLActionType.EI);
                }

                for (int j = 1; j < 5; j++)
                {
                    ActionReturnLow(j, i, UMLActionType.EI);
                }

                for (int j = 5; j < 16; j++)
                {
                    ActionReturnLow(j, i, UMLActionType.EI);
                }

                for (int j = 16; j < 55; j++)
                {
                    ActionReturnAvarage(j, i, UMLActionType.EI);
                }
            }


            /// 
            /// Test with:
            /// ActionType : EI
            /// ftrs : 2
            ///     -100 ... 0 return 0
            ///     0 ... 4 return 3
            ///     5 ... 15 return 4
            ///     16 ... 55 return 6

            for (int j = -100; j < 0; j++)
            {
                ActionReturnNothing(j, 2, UMLActionType.EI);
            }

            for (int j = 1; j < 5; j++)
            {
                ActionReturnLow(j, 2, UMLActionType.EI);
            }

            for (int j = 5; j < 16; j++)
            {
                ActionReturnAvarage(j, 2, UMLActionType.EI);
            }

            for (int j = 16; j < 55; j++)
            {
                ActionReturnHigh(j, 2, UMLActionType.EI);
            }

            /// 
            /// Test with:
            /// ActionType : EI
            /// ftrs : 3...100
            ///     -100 ... 0 return 0
            ///     0 ... 4 return 4
            ///     5 ... 15 return 6
            ///     16 ... 55 return 6
            for (int i = 3; i < 101; i++)
            {
                for (int j = -100; j < 0; j++)
                {
                    ActionReturnNothing(j, i, UMLActionType.EI);
                }

                for (int j = 1; j < 5; j++)
                {
                    ActionReturnAvarage(j, i, UMLActionType.EI);
                }

                for (int j = 5; j < 16; j++)
                {
                    ActionReturnHigh(j, i, UMLActionType.EI);
                }

                for (int j = 16; j < 55; j++)
                {
                    ActionReturnHigh(j, i, UMLActionType.EI);
                }
            }
        }
        
        [Test]
        public void TestCalulateActionFunctionPoints_EO()
        {
            /// 
            /// Test with:
            /// ActionType : EO
            /// ftrs : -25...-1
            ///     -100 ... 55 return 0
            ///
            for (int i = -25; i < -1; i++)
            {
                for (int j = -100; j < 55; j++)
                {
                    ActionReturnNothing(j, i, UMLActionType.EO);
                }
            }


            /// 
            /// Test with:
            /// ActionType : EO
            /// ftrs : 0, 1
            ///     -100 ... 0 return 0
            ///     0 ... 5 return 4
            ///     6 ... 19 return 4
            ///     20 ... 55 return 5
            for (int i = 0; i < 2; i++)
            {
                for (int j = -100; j < 0; j++)
                {
                    ActionReturnNothing(j, i, UMLActionType.EO);
                }

                for (int j = 1; j < 6; j++)
                {
                    ActionReturnLow(j, i, UMLActionType.EO);
                }

                for (int j = 6; j < 20; j++)
                {
                    ActionReturnLow(j, i, UMLActionType.EO);
                }

                for (int j = 20; j < 55; j++)
                {
                    ActionReturnAvarage(j, i, UMLActionType.EO);
                }
            }


            /// 
            /// Test with:
            /// ActionType : EI
            /// ftrs : 2
            ///     -100 ... 0 return 0
            ///     0 ... 5 return 4
            ///     6 ... 19 return 5
            ///     20 ... 55 return 7

            for (int j = -100; j < 0; j++)
            {
                ActionReturnNothing(j, 2, UMLActionType.EO);
            }

            for (int j = 1; j < 6; j++)
            {
                ActionReturnLow(j, 2, UMLActionType.EO);
            }

            for (int j = 6; j < 20; j++)
            {
                ActionReturnAvarage(j, 2, UMLActionType.EO);
            }

            for (int j = 20; j < 55; j++)
            {
                ActionReturnHigh(j, 2, UMLActionType.EO);
            }

            /// 
            /// Test with:
            /// ActionType : EI
            /// ftrs : 3...100
            ///     -100 ... 0 return 0
            ///     0 ... 4 return 5
            ///     5 ... 15 return 7
            ///     16 ... 55 return 7
            for (int i = 3; i < 101; i++)
            {
                for (int j = -100; j < 0; j++)
                {
                    ActionReturnNothing(j, i, UMLActionType.EO);
                }

                for (int j = 1; j < 6; j++)
                {
                    ActionReturnAvarage(j, i, UMLActionType.EO);
                }

                for (int j = 6; j < 20; j++)
                {
                    ActionReturnHigh(j, i, UMLActionType.EO);
                }

                for (int j = 20; j < 55; j++)
                {
                    ActionReturnHigh(j, i, UMLActionType.EO);
                }
            }
        }
        
        [Test]
        public void TestCalulateActionFunctionPoints_EQ()
        {
            /// 
            /// Test with:
            /// ActionType : EQ
            /// ftrs : -25...-1
            ///     -100 ... 55 return 0
            ///
            for (int i = -25; i < -1; i++)
            {
                for (int j = -100; j < 55; j++)
                {
                    ActionReturnNothing(j, i, UMLActionType.EQ);
                }
            }


            /// 
            /// Test with:
            /// ActionType : EO
            /// ftrs : 0, 1
            ///     -100 ... 0 return 0
            ///     0 ... 5 return 3
            ///     6 ... 19 return 3
            ///     20 ... 55 return 4
            for (int i = 0; i < 2; i++)
            {
                for (int j = -100; j < 0; j++)
                {
                    ActionReturnNothing(j, i, UMLActionType.EQ);
                }

                for (int j = 1; j < 6; j++)
                {
                    ActionReturnLow(j, i, UMLActionType.EQ);
                }

                for (int j = 6; j < 20; j++)
                {
                    ActionReturnLow(j, i, UMLActionType.EQ);
                }

                for (int j = 20; j < 55; j++)
                {
                    ActionReturnAvarage(j, i, UMLActionType.EQ);
                }
            }


            /// 
            /// Test with:
            /// ActionType : EI
            /// ftrs : 2
            ///     -100 ... 0 return 0
            ///     0 ... 5 return 3
            ///     6 ... 19 return 4
            ///     20 ... 55 return 6

            for (int j = -100; j < 0; j++)
            {
                ActionReturnNothing(j, 2, UMLActionType.EQ);
            }

            for (int j = 1; j < 6; j++)
            {
                ActionReturnLow(j, 2, UMLActionType.EQ);
            }

            for (int j = 6; j < 20; j++)
            {
                ActionReturnAvarage(j, 2, UMLActionType.EQ);
            }

            for (int j = 20; j < 55; j++)
            {
                ActionReturnHigh(j, 2, UMLActionType.EQ);
            }

            /// 
            /// Test with:
            /// ActionType : EI
            /// ftrs : 3...100
            ///     -100 ... 0 return 0
            ///     0 ... 4 return 4
            ///     5 ... 15 return 6
            ///     16 ... 55 return 6
            for (int i = 3; i < 101; i++)
            {
                for (int j = -100; j < 0; j++)
                {
                    ActionReturnNothing(j, i, UMLActionType.EQ);
                }

                for (int j = 1; j < 6; j++)
                {
                    ActionReturnAvarage(j, i, UMLActionType.EQ);
                }

                for (int j = 6; j < 20; j++)
                {
                    ActionReturnHigh(j, i, UMLActionType.EQ);
                }

                for (int j = 20; j < 55; j++)
                {
                    ActionReturnHigh(j, i, UMLActionType.EQ);
                }
            }
        }


        [Test]
        public void TestEsmtition()
        {
            //Helper.OpenFile(Path.GetDirectoryName(@"C:\Temp\Emanuel\Desarrollo\ProjectoDesarrollo\PES\TUPUX.Test\bin\Debug\TestProjects\Test1.uml"));

            UMLProject project = UMLProject.GetInstance();

            UMLPhaseCollection phases = project.GetUMLPhases();

            foreach (UMLPhase phase in phases)
            {
                phase.LoadCollections();
                phase.EstimateFunctionPoints();
                phase.SaveEdit();
            }

            foreach (UMLPhase phase in phases)
            {
                if (phase.Name.Equals("PhaseClass1"))
                {
                    Assert.AreEqual(2, phase.Iterations.Count);
                    Assert.AreEqual(11, phase.ActionFunctionPoints);
                    Assert.AreEqual(24, phase.FileFunctionPoints);

                    foreach(UMLIteration iteration in phase.Iterations)
                    {
                        if (iteration.Name.Equals("Iteration 1"))
                        {
                            Assert.AreEqual(3, iteration.ActionFunctionPoints);
                            Assert.AreEqual(7, iteration.FileFunctionPoints);
                            
                            //foreach (UMLCollaboration col in iteration.CollaborationsInUseCases)
                            //{
                            //    if (col.Name.Equals("Collaboration11"))
                            //    {
                            //        Assert.AreEqual(3, col.ActionFunctionPoints);
                            //        Assert.AreEqual(7, col.FilesFunctionPoints);
                            //    }
                            //}
                            continue;
                        }

                        if (iteration.Name.Equals("Iteration 2"))
                        {
                            Assert.AreEqual(8, iteration.ActionFunctionPoints);
                            Assert.AreEqual(17, iteration.FileFunctionPoints);
                            
                            //foreach (UMLCollaboration col in iteration.CollaborationsInUseCases)
                            //{
                            //    if (col.Name.Equals("Collaboration21"))
                            //    {
                            //        Assert.AreEqual(4, col.ActionFunctionPoints);
                            //        Assert.AreEqual(7, col.FilesFunctionPoints);
                            //    }

                            //    if (col.Name.Equals("Collaboration22"))
                            //    {
                            //        Assert.AreEqual(4, col.ActionFunctionPoints);
                            //        Assert.AreEqual(10, col.FilesFunctionPoints);
                            //    }
                            //}
                        }
                    }
                }
            }
            
        }
        
        [Test]
        public void TestEsmtition2()
        {
            //Helper.OpenFile(Path.GetDirectoryName(@"C:\Temp\Emanuel\Desarrollo\ProjectoDesarrollo\PES\TUPUX.Test\bin\Debug\TestProjects\Test1.uml"));

            UMLProject project = UMLProject.GetInstance();

            UMLPhaseCollection phases = project.GetUMLPhases();

            foreach (UMLPhase phase in phases)
            {
                phase.LoadCollections();
                phase.EstimateFunctionPoints();
                phase.SaveEdit();
            }

            foreach (UMLPhase phase in phases)
            {
                if (phase.Name.Equals("PhaseClass1"))
                {
                    Assert.AreEqual(2, phase.Iterations.Count);
                    Assert.AreEqual(14, phase.ActionFunctionPoints);
                    Assert.AreEqual(31, phase.FileFunctionPoints);

                    foreach (UMLIteration iteration in phase.Iterations)
                    {
                        if (iteration.Name.Equals("Iteration 1"))
                        {
                            Assert.AreEqual(6, iteration.ActionFunctionPoints);
                            Assert.AreEqual(14, iteration.FileFunctionPoints);
                            
                            //foreach (UMLCollaboration col in iteration.CollaborationsInUseCases)
                            //{
                            //    if (col.Name.Equals("Collaboration11"))
                            //    {
                            //        Assert.AreEqual(6, col.ActionFunctionPoints);
                            //        Assert.AreEqual(14, col.FilesFunctionPoints);
                            //    }
                            //}
                            continue;
                        }

                        if (iteration.Name.Equals("Iteration 2"))
                        {
                            Assert.AreEqual(8, iteration.ActionFunctionPoints);
                            Assert.AreEqual(17, iteration.FileFunctionPoints);
                            
                            //foreach (UMLCollaboration col in iteration.CollaborationsInUseCases)
                            //{
                            //    if (col.Name.Equals("Collaboration21"))
                            //    {
                            //        Assert.AreEqual(4, col.ActionFunctionPoints);
                            //        Assert.AreEqual(7, col.FilesFunctionPoints);
                            //    }

                            //    if (col.Name.Equals("Collaboration22"))
                            //    {
                            //        Assert.AreEqual(4, col.ActionFunctionPoints);
                            //        Assert.AreEqual(10, col.FilesFunctionPoints);
                            //    }
                            //}
                        }
                    }
                }
            }

        }

        [Test]
        public void TestEsmtition3()
        {
            //Helper.OpenFile(Path.GetDirectoryName(@"C:\Temp\Emanuel\Desarrollo\ProjectoDesarrollo\PES\TUPUX.Test\bin\Debug\TestProjects\Test1.uml"));

            UMLProject project = UMLProject.GetInstance();

            UMLPhaseCollection phases = project.GetUMLPhases();

            foreach (UMLPhase phase in phases)
            {
                phase.LoadCollections();
                phase.EstimateFunctionPoints();
                phase.SaveEdit();
            }

            foreach (UMLPhase phase in phases)
            {
                if (phase.Name.Equals("PhaseClass1"))
                {
                    Assert.AreEqual(2, phase.Iterations.Count);
                    Assert.AreEqual(20, phase.ActionFunctionPoints);
                    Assert.AreEqual(31, phase.FileFunctionPoints);

                    foreach (UMLIteration iteration in phase.Iterations)
                    {
                        if (iteration.Name.Equals("Iteration 1"))
                        {
                            Assert.AreEqual(12, iteration.ActionFunctionPoints);
                            Assert.AreEqual(22.5, iteration.FileFunctionPoints);
                            
                            //foreach (UMLCollaboration col in iteration.CollaborationsInUseCases)
                            //{
                            //    if (col.Name.Equals("Collaboration11"))
                            //    {
                            //        Assert.AreEqual(6, col.ActionFunctionPoints);
                            //        Assert.AreEqual(10.5, col.FilesFunctionPoints);
                            //        continue;
                            //    }

                            //    if (col.Name.Equals("Collaboration12"))
                            //    {
                            //        Assert.AreEqual(6, col.ActionFunctionPoints);
                            //        Assert.AreEqual(12, col.FilesFunctionPoints);
                            //    }
                            //}
                            continue;
                        }

                        if (iteration.Name.Equals("Iteration 2"))
                        {
                            Assert.AreEqual(8, iteration.ActionFunctionPoints);
                            Assert.AreEqual(8.5, iteration.FileFunctionPoints);
                            
                            //foreach (UMLCollaboration col in iteration.CollaborationsInUseCases)
                            //{
                            //    if (col.Name.Equals("Collaboration21"))
                            //    {
                            //        Assert.AreEqual(4, col.ActionFunctionPoints);
                            //        Assert.AreEqual(3.5, col.FilesFunctionPoints);
                            //    }

                            //    if (col.Name.Equals("Collaboration22"))
                            //    {
                            //        Assert.AreEqual(4, col.ActionFunctionPoints);
                            //        Assert.AreEqual(5, col.FilesFunctionPoints);
                            //    }
                            //}
                        }
                    }
                }
            }

        }


        [Test]
        public void TestEsmtition4()
        {
            //Helper.OpenFile(Path.GetDirectoryName(@"C:\Temp\Emanuel\Desarrollo\ProjectoDesarrollo\PES\TUPUX.Test\bin\Debug\TestProjects\Test1.uml"));

            UMLProject project = UMLProject.GetInstance();

            UMLPhaseCollection phases = project.GetUMLPhases();

            foreach (UMLPhase phase in phases)
            {
                phase.LoadCollections();
                phase.EstimateFunctionPoints();
                phase.SaveEdit();
            }

            foreach (UMLPhase phase in phases)
            {
                if (phase.Name.Equals("PhaseClass1"))
                {
                    Assert.AreEqual(3, phase.Iterations.Count);
                    Assert.AreEqual(39, Math.Round(phase.ActionFunctionPoints,0));
                    Assert.AreEqual(51, Math.Round(phase.FileFunctionPoints,0));

                    foreach (UMLIteration iteration in phase.Iterations)
                    {
                        if (iteration.Name.Equals("Iteration 1"))
                        {
                            Assert.AreEqual(12, iteration.ActionFunctionPoints);
                            Assert.AreEqual(16.17, Math.Round(iteration.FileFunctionPoints,2));
                            
                            //foreach (UMLCollaboration col in iteration.CollaborationsInUseCases)
                            //{
                            //    if (col.Name.Equals("Collaboration11"))
                            //    {
                            //        Assert.AreEqual(6, col.ActionFunctionPoints);
                            //        Assert.AreEqual(7, Math.Round(col.FilesFunctionPoints,2));
                            //        continue;
                            //    }

                            //    if (col.Name.Equals("Collaboration12"))
                            //    {
                            //        Assert.AreEqual(6, col.ActionFunctionPoints);
                            //        Assert.AreEqual(9.17, Math.Round(col.FilesFunctionPoints,2));
                            //    }
                            //}
                            continue;
                        }

                        if (iteration.Name.Equals("Iteration 2"))
                        {
                            Assert.AreEqual(8, iteration.ActionFunctionPoints);
                            Assert.AreEqual(5.67, Math.Round(iteration.FileFunctionPoints,2));
                            
                            //foreach (UMLCollaboration col in iteration.CollaborationsInUseCases)
                            //{
                            //    if (col.Name.Equals("Collaboration21"))
                            //    {
                            //        Assert.AreEqual(4, col.ActionFunctionPoints);
                            //        Assert.AreEqual(2.33, Math.Round(col.FilesFunctionPoints, 2));
                            //    }

                            //    if (col.Name.Equals("Collaboration22"))
                            //    {
                            //        Assert.AreEqual(4, col.ActionFunctionPoints);
                            //        Assert.AreEqual(3.33, Math.Round(col.FilesFunctionPoints,2));
                            //    }
                            //}

                            continue;
                        }


                        if (iteration.Name.Equals("Iteration 3"))
                        {
                            Assert.AreEqual(19, iteration.ActionFunctionPoints);
                            Assert.AreEqual(29.17, Math.Round(iteration.FileFunctionPoints,2));
                            
                            //foreach (UMLCollaboration col in iteration.CollaborationsInUseCases)
                            //{
                            //    if (col.Name.Equals("Collaboration31"))
                            //    {
                            //        Assert.AreEqual(7, col.ActionFunctionPoints);
                            //        Assert.AreEqual(6.67, Math.Round(col.FilesFunctionPoints,2));
                            //    }

                            //    if (col.Name.Equals("Collaboration32"))
                            //    {
                            //        Assert.AreEqual(6, col.ActionFunctionPoints);
                            //        Assert.AreEqual(6.67, Math.Round(col.FilesFunctionPoints,2));
                            //    }

                            //    if (col.Name.Equals("Collaboration33"))
                            //    {
                            //        Assert.AreEqual(6, col.ActionFunctionPoints);
                            //        Assert.AreEqual(15.83, Math.Round(col.FilesFunctionPoints,2));
                            //    }
                            //}

                            continue;
                        }
                    }
                }
            }

        }

        [Test]
        public void TestEsmtition5()
        {
            //Helper.OpenFile(Path.GetDirectoryName(@"C:\Temp\Emanuel\Desarrollo\ProjectoDesarrollo\PES\TUPUX.Test\bin\Debug\TestProjects\Test1.uml"));

            UMLProject project = UMLProject.GetInstance();

            UMLPhaseCollection phases = project.GetUMLPhases();

            foreach (UMLPhase phase in phases)
            {
                phase.LoadCollections();
                phase.EstimateFunctionPoints();
                phase.SaveEdit();
            }

            foreach (UMLPhase phase in phases)
            {
                if (phase.Name.Equals("PhaseClass1"))
                {
                    Assert.AreEqual(4, phase.Iterations.Count);
                    Assert.AreEqual(51, Math.Round(phase.ActionFunctionPoints, 0));
                    Assert.AreEqual(72, Math.Round(phase.FileFunctionPoints, 0));

                    foreach (UMLIteration iteration in phase.Iterations)
                    {
                        if (iteration.Name.Equals("Iteration 1"))
                        {
                            Assert.AreEqual(12, iteration.ActionFunctionPoints);
                            Assert.AreEqual(16.17, Math.Round(iteration.FileFunctionPoints, 2));
                            
                            //foreach (UMLCollaboration col in iteration.CollaborationsInUseCases)
                            //{
                            //    if (col.Name.Equals("Collaboration11"))
                            //    {
                            //        Assert.AreEqual(6, col.ActionFunctionPoints);
                            //        Assert.AreEqual(7, Math.Round(col.FilesFunctionPoints, 2));
                            //        continue;
                            //    }

                            //    if (col.Name.Equals("Collaboration12"))
                            //    {
                            //        Assert.AreEqual(6, col.ActionFunctionPoints);
                            //        Assert.AreEqual(9.17, Math.Round(col.FilesFunctionPoints, 2));
                            //    }
                            //}
                            continue;
                        }

                        if (iteration.Name.Equals("Iteration 2"))
                        {
                            Assert.AreEqual(8, iteration.ActionFunctionPoints);
                            Assert.AreEqual(5.67, Math.Round(iteration.FileFunctionPoints, 2));
                            
                            //foreach (UMLCollaboration col in iteration.CollaborationsInUseCases)
                            //{
                            //    if (col.Name.Equals("Collaboration21"))
                            //    {
                            //        Assert.AreEqual(4, col.ActionFunctionPoints);
                            //        Assert.AreEqual(2.33, Math.Round(col.FilesFunctionPoints, 2));
                            //    }

                            //    if (col.Name.Equals("Collaboration22"))
                            //    {
                            //        Assert.AreEqual(4, col.ActionFunctionPoints);
                            //        Assert.AreEqual(3.33, Math.Round(col.FilesFunctionPoints, 2));
                            //    }
                            //}

                            continue;
                        }


                        if (iteration.Name.Equals("Iteration 3"))
                        {
                            Assert.AreEqual(19, iteration.ActionFunctionPoints);
                            Assert.AreEqual(29.17, Math.Round(iteration.FileFunctionPoints, 2));
                           
                            //foreach (UMLCollaboration col in iteration.CollaborationsInUseCases)
                            //{
                            //    if (col.Name.Equals("Collaboration31"))
                            //    {
                            //        Assert.AreEqual(7, col.ActionFunctionPoints);
                            //        Assert.AreEqual(6.67, Math.Round(col.FilesFunctionPoints, 2));
                            //    }

                            //    if (col.Name.Equals("Collaboration32"))
                            //    {
                            //        Assert.AreEqual(6, col.ActionFunctionPoints);
                            //        Assert.AreEqual(6.67, Math.Round(col.FilesFunctionPoints, 2));
                            //    }

                            //    if (col.Name.Equals("Collaboration33"))
                            //    {
                            //        Assert.AreEqual(6, col.ActionFunctionPoints);
                            //        Assert.AreEqual(15.83, Math.Round(col.FilesFunctionPoints, 2));
                            //    }
                            //}

                            continue;
                        }


                        if (iteration.Name.Equals("Iteration 4"))
                        {
                            Assert.AreEqual(12, iteration.ActionFunctionPoints);
                            Assert.AreEqual(21, Math.Round(iteration.FileFunctionPoints, 0));
                            
                            //foreach (UMLCollaboration col in iteration.CollaborationsInUseCases)
                            //{
                            //    if (col.Name.Equals("Collaboration41"))
                            //    {
                            //        Assert.AreEqual(4, col.ActionFunctionPoints);
                            //        Assert.AreEqual(10.5, Math.Round(col.FilesFunctionPoints, 1));
                            //    }

                            //    if (col.Name.Equals("Collaboration42"))
                            //    {
                            //        Assert.AreEqual(5, col.ActionFunctionPoints);
                            //        Assert.AreEqual(7, Math.Round(col.FilesFunctionPoints, 0));
                            //    }

                            //    if (col.Name.Equals("Collaboration43"))
                            //    {
                            //        Assert.AreEqual(3, col.ActionFunctionPoints);
                            //        Assert.AreEqual(3.5, Math.Round(col.FilesFunctionPoints, 1));
                            //    }
                            //}                            
                        }
                    }
                }
            }

        }
    }
}

