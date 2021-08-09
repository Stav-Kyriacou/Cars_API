using System;

namespace CarsLib
{
    public class Owner
    {
        public string Name { get; set; }
        public int LicenceNo { get; set; }

        public Owner (string name, int licenceNo)
        {
            this.Name = name;
            SetLicenceNo(licenceNo);
        }
        public void SetLicenceNo(int licenceNo)
        {
            if (licenceNo.ToString().Length != 10)
            {
                this.LicenceNo = 0;
            }
            else
            {
                this.LicenceNo = licenceNo;
            }
        }
    }
}