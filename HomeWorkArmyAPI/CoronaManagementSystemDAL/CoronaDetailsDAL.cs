using CoronaManagementSystemDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoronaManagementSystemDAL
{
    public class CoronaDetailsDAL : ICoronaDetailsDAL
    {
        CoronaManagementSystemContext _context = new CoronaManagementSystemContext();
        public List<CoronaDetails> GetAllCoronaDetials()
        {
            try
            {
                return _context.CoronaDetails.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CoronaDetails getCoronaDetailById(string id)
        {
            try
            {
                return _context.CoronaDetails.SingleOrDefault(x => x.PersonId.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddUserNameDetails(string PersonId)
        {
            try
            {
                CoronaDetails NewCoronaDetials = new CoronaDetails(PersonId);

                _context.CoronaDetails.Add(NewCoronaDetials);

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool UpdateCoronaDetails(String id, CoronaDetails userNameCoronaDetials)
        {
            try
            {
                CoronaDetails currentUserName = _context.CoronaDetails.SingleOrDefault(x => x.PersonId == id);
                _context.Entry(currentUserName).CurrentValues.SetValues(userNameCoronaDetials);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int[] numberOfVaccinatorsInMonth()
        {
            int[] vaccitors = new int[31];
            int yearNow = DateTime.Now.Year;
            int monthNow =DateTime.Now.Month;
           

            DateTime[] dateVaccine1 = _context.CoronaDetails.Select(x => x.CoronaVaccine.Value).ToArray();
            DateTime[] dateVaccine2 = _context.CoronaDetails.Select(x => x.CoronaVaccine2.Value).ToArray();
            DateTime[] dateVaccine3 = _context.CoronaDetails.Select(x => x.CoronaVaccine3.Value).ToArray();
            DateTime[] dateVaccine4 = _context.CoronaDetails.Select(x => x.CoronaVaccine4.Value).ToArray();


            for (int i = 0; i < dateVaccine1.Length; i++)
            {
                if (dateVaccine1[i].Year == yearNow && dateVaccine1[i].Month == monthNow)
                    vaccitors[dateVaccine1[i].Day + 1]++;

                if (dateVaccine2[i].Year == yearNow && dateVaccine2[i].Month == monthNow)
                    vaccitors[dateVaccine2[i].Day + 1]++;
           
             if (dateVaccine3[i].Year == yearNow && dateVaccine3[i].Month == monthNow)
                    vaccitors[dateVaccine3[i].Day + 1]++;
     
                if (dateVaccine4[i].Year == yearNow && dateVaccine4[i].Month == monthNow)
                    vaccitors[dateVaccine4[i].Day + 1]++;
            }
            return vaccitors;
        }

    }
}
