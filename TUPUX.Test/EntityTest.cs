using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TUPUX.Entity;
using TUPUX.ActiveRecord;

namespace TUPUX.Test
{
    [TestFixture]
    public class EntityTest
    {
        [Test]
        public void CreateFile()
        {
            UMLProject project = null;            
            project = UMLProject.GetInstance();
            List<IUMLElement> elements = project.GetOwnedElements();

            if (elements.Count > 0)
            {
                UMLFile file = new UMLFile();
                file.Owner = elements[0];
                file.Name = "Test";
                file.Dets = 2;
                file.Rets = 3;
                file.Save();
                Assert.AreNotEqual(null, file);
                Assert.AreNotEqual(String.Empty, file.Guid);
                Assert.AreNotEqual(null, file.Guid);

                Assert.AreEqual("Test", file.Name);
                Assert.AreNotEqual(String.Empty, file.Name);
                Assert.AreNotEqual(null, file.Name);
                
                Assert.AreNotEqual(String.Empty, file.PathName);
                Assert.AreNotEqual(null, file.PathName);

                Assert.AreEqual(2, file.Dets);
                Assert.AreEqual(3, file.Rets);
            }
        }
        
        [Test]
        public void CreateUseCase()
        {
            UMLProject project = null;
            project = UMLProject.GetInstance();
            List<IUMLElement> elements = project.GetOwnedElements();

            if (elements.Count > 0)
            {
                UMLUseCase uc = new UMLUseCase();
                uc.Owner = elements[0];
                uc.Name = "UC Test";
                uc.Purpose = "Purpose";
                uc.Resume = "Resume";
                uc.Save();
                Assert.AreNotEqual(null, uc);
                Assert.AreNotEqual(String.Empty, uc.Guid);
                Assert.AreNotEqual(null, uc.Guid);
                
                Assert.AreEqual("UC Test", uc.Name);
                Assert.AreNotEqual(String.Empty, uc.Name);
                Assert.AreNotEqual(null, uc.Name);

                Assert.AreNotEqual(String.Empty, uc.PathName);
                Assert.AreNotEqual(null, uc.PathName);

                Assert.AreEqual("Purpose", uc.Purpose);
                Assert.AreNotEqual(String.Empty, uc.Purpose);
                Assert.AreNotEqual(null, uc.Purpose);

                Assert.AreEqual("Resume", uc.Resume);
                Assert.AreNotEqual(String.Empty, uc.Resume);
                Assert.AreNotEqual(null, uc.Resume);
            }
        }
        
        [Test]
        public void CreateCollaboration()
        {
            UMLProject project = null;
            project = UMLProject.GetInstance();
            List<IUMLElement> elements = project.GetOwnedElements();

            if (elements.Count > 0)
            {
                UMLUseCase uc = new UMLUseCase();
                uc.Owner = elements[0];
                uc.Name = "UC Test Collaboration";                
                uc.Save();

                UMLCollaboration coll = new UMLCollaboration();
                coll.Owner = uc;
                coll.Name = "Collaboration EI";
                coll.Type = UMLActionType.EI;
                coll.GenerateAction = true;
                coll.SendMessage = true;
                coll.Save();

                Assert.AreNotEqual(null, coll);
                Assert.AreNotEqual(String.Empty, coll.Guid);
                Assert.AreNotEqual(null, coll.Guid);
                Assert.AreEqual("Collaboration EI", coll.Name);
                Assert.AreNotEqual(String.Empty, coll.Name);
                Assert.AreNotEqual(null, coll.Name);

                Assert.AreNotEqual(String.Empty, coll.PathName);
                Assert.AreNotEqual(null, coll.PathName);

                Assert.AreEqual(UMLActionType.EI, coll.Type);

                Assert.AreEqual(true, coll.GenerateAction);
                Assert.AreEqual(true, coll.SendMessage);

                
                UMLCollaboration coll2 = new UMLCollaboration();
                coll2.Owner = uc;
                coll2.Name = "Collaboration EO";
                coll2.Type = UMLActionType.EO;
                coll2.GenerateAction = true;
                coll2.SendMessage = false;
                coll2.Save();

                Assert.AreNotEqual(null, coll2);
                Assert.AreNotEqual(String.Empty, coll2.Guid);
                Assert.AreNotEqual(null, coll2.Guid);

                Assert.AreEqual("Collaboration EO", coll2.Name);
                Assert.AreNotEqual(String.Empty, coll2.Name);
                Assert.AreNotEqual(null, coll2.Name);

                Assert.AreNotEqual(String.Empty, coll2.PathName);
                Assert.AreNotEqual(null, coll2.PathName);
                Assert.AreEqual(UMLActionType.EO, coll2.Type);

                Assert.AreEqual(true, coll2.GenerateAction);
                Assert.AreEqual(false, coll2.SendMessage);


                UMLCollaboration coll3 = new UMLCollaboration();
                coll3.Owner = uc;
                coll3.Name = "Collaboration EQ";
                coll3.Type = UMLActionType.EQ;
                coll3.Save();

                Assert.AreNotEqual(null, coll3);
                Assert.AreNotEqual(String.Empty, coll3.Guid);
                Assert.AreNotEqual(null, coll3.Guid);
                
                Assert.AreEqual("Collaboration EQ", coll3.Name);
                Assert.AreNotEqual(String.Empty, coll3.Name);
                Assert.AreNotEqual(null, coll3.Name);

                Assert.AreNotEqual(String.Empty, coll3.PathName);
                Assert.AreNotEqual(null, coll3.PathName);

                Assert.AreEqual(UMLActionType.EQ, coll3.Type);

                Assert.AreEqual(false, coll3.GenerateAction);
                Assert.AreEqual(false, coll3.SendMessage);
            }
        }
        
        [Test]
        public void CreatePhase()
        {
            UMLProject project = null;
            project = UMLProject.GetInstance();
            List<IUMLElement> elements = project.GetOwnedElements();

            if (elements.Count > 0)
            {
                UMLPhase phase = new UMLPhase();
                phase.Owner = elements[0];
                phase.Name = "Phase Test";
                phase.SaveEdit();
                Assert.AreNotEqual(null, phase);
                Assert.AreNotEqual(String.Empty, phase.Guid);
                Assert.AreNotEqual(null, phase.Guid);
                Assert.AreEqual("Phase Test", phase.Name);
                Assert.AreNotEqual(String.Empty, phase.PathName);
                Assert.AreNotEqual(null, phase.PathName);
            }
        }
        
        [Test]
        public void CreateIteration()
        {
            UMLProject project = null;
            project = UMLProject.GetInstance();
            List<IUMLElement> elements = project.GetOwnedElements();

            if (elements.Count > 0)
            {
                UMLIteration iteration = new UMLIteration();
                iteration.Owner = elements[0];
                iteration.Name = "Iteration Test";
                iteration.Save();
                Assert.AreNotEqual(null, iteration);
                Assert.AreNotEqual(String.Empty, iteration.Guid);
                Assert.AreNotEqual(null, iteration.Guid);
                Assert.AreEqual("Iteration Test", iteration.Name);
                Assert.AreNotEqual(String.Empty, iteration.PathName);
                Assert.AreNotEqual(null, iteration.PathName);
            }
        }
        
        [Test]
        public void TestGetProject()
        {
            
            UMLProject project = null;
            try
            {
                project = UMLProject.GetInstance();
            }
            catch { }            
            Assert.AreNotEqual(null, project);
            Assert.AreNotEqual(String.Empty, project.Guid);
            Assert.AreNotEqual(null, project.Guid);
        }

    }
}
