﻿using System;
using System.IO;
using NHibernate;
using NHibernate.Cfg;

namespace DataAccessObject
{
    public class NHibernateHelper
    {
        private static ISessionFactory _factory;

        public static ISession Session
        {
            get
            {
                if (_factory == null)
                {
                    var cfg = new Configuration();
                    _factory =
                        cfg.Configure(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hibernate.cfg.xml"))
                            .BuildSessionFactory();
                }

                return _factory.OpenSession();
            }
        }

    }
}
