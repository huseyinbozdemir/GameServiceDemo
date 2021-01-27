using System;
using System.Collections.Generic;
using System.Text;

namespace GameServiceDemo
{
    class PlayerManager : EntityService
    {
        List<LoggerService> _loggerServices;
        List<ValidateService> _validateServices;
        public PlayerManager(List<LoggerService> loggerService, List<ValidateService> validateServices)
        {
            _loggerServices = loggerService;
            _validateServices = validateServices;
        }
        public void Add(Entity person)
        {
            try
            {
                foreach (var vals in _validateServices)
                {
                    vals.ValidatePerson((Person)person);
                }
                foreach (var logs in _loggerServices)
                {
                    logs.Add(person);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public void Update(Entity person)
        {
            try
            {
                foreach (var logs in _loggerServices)
                {
                    logs.Update(person);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public void Remove(Entity person)
        {
            try
            {
                foreach (var logs in _loggerServices)
                {
                    logs.Remove(person);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
