using System;
using AppPenalty.Shared.Repos;

namespace AppPenalty.Shared
{
    public class SeedData
    {
        private static RepoOsago _osagoRepo;
        public static RepoOsago OsagoRepo
        {
            get
            {
                if (_osagoRepo != null) return _osagoRepo;
                _osagoRepo = new RepoOsago("Osagos.txt");
                return _osagoRepo;
            }
        }
    }
}
