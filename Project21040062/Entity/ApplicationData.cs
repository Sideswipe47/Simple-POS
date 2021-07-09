using System.Text.Json.Serialization;

namespace Project21040062.Entity
{
    public class ApplicationData
    {

        #region Variables
        // [ Singleton ]
        public static ApplicationData appData;

        // [ Attributes ]
        public string companyName { get; }
        public uint employeeId { get; set; }
        #endregion

        #region Constructors
        public ApplicationData() { }

        [JsonConstructor]
        public ApplicationData(string companyName)
        {
            this.companyName = companyName;
            this.employeeId = 1;
        }
        #endregion

        #region Methods
        // Get incremental employee id
        public uint GetEmployeeId() { return employeeId++; }
        #endregion

    }
}
