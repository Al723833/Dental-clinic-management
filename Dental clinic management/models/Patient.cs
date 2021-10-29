using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_clinic_management
{

        class Patient
        {
            public int id { get; set; }
            public String First_Name { get; set; }
            public String middle_name { get; set; }
            public String last_name { get; set; }
            public String day_data { get; set; }
            public String note_sick { get; set; }
            public double sum_value { get; set; }
            public double value_dofaa { get; set; }
            public double value_Discount { get; set; }
            public int sub_Patient_id { get; set; }
            public String date_of_birth { get; set; }
            public String mobile_number { get; set; }
            public String mobile_number_Spare { get; set; }
            public String Patient_Address { get; set; }
            public String chronic_diseases { get; set; }
            public String Polarization_method { get; set; }


           // public static List<Patient> listPatient = new DataBasePatient().PatientCURD(1, "", "", "", 0.0, 0.0, 0.0, 0, "", "", "", "", "", "", "Select");

            public Patient(
                int id,
                String First_Name,
                String middle_name,
                String last_name,
                String day_data,
                String note_sick,
                double sum_value,
                double value_dofaa,
                double value_Discount,
                int sub_Patient_id,
                String date_of_birth,
                String mobile_number,
                String mobile_number_Spare,
                String Patient_Address,
                String chronic_diseases,
                String Polarization_method
                )
            {
                this.id = id;
                this.First_Name = First_Name;
                this.middle_name = middle_name;
                this.last_name = last_name;
                this.day_data = day_data;
                this.note_sick = note_sick;
                this.sum_value = sum_value;
                this.value_dofaa = value_dofaa;
                this.value_Discount = value_Discount;
                this.sub_Patient_id = sub_Patient_id;
                this.date_of_birth = date_of_birth;
                this.mobile_number = mobile_number;
                this.mobile_number_Spare = mobile_number_Spare;
                this.Patient_Address = Patient_Address;
                this.chronic_diseases = chronic_diseases;
                this.Polarization_method = Polarization_method;
            }
        }
    }

