using exam.models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DbConnection = exam.models.DbConnection;

namespace exam.controllers
{
    public class AddRequestController
    {

        public void AddNewRequest(long climateTechTypeId, string climateTechModel, string problemDescryption)
        {
            if (climateTechModel == "")
            {
                throw new Exception("Ошибка. Модель не заполнена.");
            }

            if (problemDescryption == "")
            {
                throw new Exception("Ошибка. Описание проблемы не заполнено.");
            }

            try
            {
                Requests request = new Requests()
                {
                    StartDate = DateTime.Now,
                    ClimateTechTypeId = climateTechTypeId,
                    ClimateTechModel = climateTechModel,
                    ProblemDescription = problemDescryption,
                    RequestStatusId = 1,
                    CompletionDate = null,
                    RepairParts = null,
                    MasterId = null,
                    ClientId = FrameNavigate.user.id,
                };

                DbConnection.Examentities.Requests.Add(request);
                DbConnection.Examentities.SaveChanges();

            }
            catch (Exception e)
            {
                throw new Exception("Ошибка соединения с БД");
            }

        }
    }
}
