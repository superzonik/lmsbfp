using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBFP.components
{
    class Values
    {
        Connection connection = new Connection();

        public static string server_address = "127.0.0.1";
        public static string server_port = "3305";
        public static string server_username = "superzonik";
        public static string server_password = "4735489";

        // <summary>
        // User Data
        public static int user_admin = 1;
        public static int user_id = 1;
        public static int user_level;
        public static string username;
        public static bool user_active;

        public int UserID
        {
            get { return user_id; }
            set { user_id = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public int UserLevel
        {
            get { return user_level; }
            set { user_level = value; }
        }

        public bool UserActive
        {
            get { return user_active; }
            set { user_active = value; }
        }

        public string UserStatus
        {
            get
            {
                if (user_active == true)
                {
                    return "Active";
                }
                else
                {
                    return "Inactive";
                }
            }
        }

        // </summary>

        // <summary>
        // DASHBOARD QUICK SUMMARY OF INVENTORY

        public static int drre_equipment;
        public static int office_equipment;
        public static int ict_equipment;
        public static int other_machineries;
        public static int motor_vehicles;
        public static int medical_dental;        
        public static int sagf;
        public static int foreign_grants;
        public static int communication_equipment;
        public static int motorpool_tools;
        public static int mpase_firearms;

        public int DRREequipment
        {
            get { return drre_equipment; }
            set { drre_equipment = value; }
        }

        public int OfficeEquipment
        {
            get { return office_equipment; }
            set { office_equipment = value; }
        }

        public int ICTequipment
        {
            get { return ict_equipment; }
            set { ict_equipment = value; }
        }

        public int OtherMachineries
        {
            get { return other_machineries; }
            set { other_machineries= value; }
        }

        public int MotorVehicles
        {
            get { return motor_vehicles; }
            set { motor_vehicles = value; }
        }

        public int MedicalDental
        {
            get { return medical_dental; }
            set { medical_dental= value; }
        }

        public int SAGF
        {
            get { return sagf; }
            set { sagf = value; }
        }

        public int ForeignGrants
        {
            get { return foreign_grants; }
            set { foreign_grants= value; }
        }

        public int CommunicationEquipment
        {
            get { return communication_equipment; }
            set { communication_equipment= value; }
        }

        public int MotorpoolTools
        {
            get { return motorpool_tools; }
            set { motorpool_tools= value; }
        }

        public int MPASEFirearms
        {
            get { return mpase_firearms; }
            set { mpase_firearms= value; }
        }

        // </summary
    }

}
