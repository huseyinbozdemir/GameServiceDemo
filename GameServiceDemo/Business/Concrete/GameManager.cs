using System;
using System.Collections.Generic;
using System.Text;

namespace GameServiceDemo
{
    class GameManager : EntityService
    {
        List<LoggerService> _loggerServices;
        public GameManager(List<LoggerService> loggerServices)
        {
            _loggerServices = loggerServices;
        }
        public void Add(Entity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Add(game);
            }
        }

        public void Update(Entity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Update(game);
            }
        }
        public void Remove(Entity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Remove(game);
            }
        }
    }
}
