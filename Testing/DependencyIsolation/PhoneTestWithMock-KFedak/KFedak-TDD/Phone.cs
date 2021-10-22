﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_TDD
{
    public abstract class Phone : ITelephone
    {
        public string PhoneName { get; set; }
        public int BatteryLevel { get; set; }

        public ILogger Logger= new Logger();

        internal Phone(int batteryLevel, string phoneName, ILogger logger)
        {
            this.PhoneName = phoneName;
            this.Logger = logger;

            if (batteryLevel < 0 || batteryLevel > 100)
            {
                Logger.WriteLine(new InvalidValueForBattery(this.BatteryLevel, $"Invalid value!").Message);

                throw new InvalidValueForBattery(this.BatteryLevel, $"Invalid value!");
            }
            else
            {
                this.BatteryLevel = batteryLevel;
            }
        }

        public void CallAmbulance()
        {
            if (this.BatteryLevel >= 5)
            {
                this.BatteryLevel -= 5;

                Logger.WriteLine(new Exception($"Calling an ambulance from {PhoneName}, remaining charge: {BatteryLevel}%").Message);
            }
            else
            {
                this.BatteryLevel = 0;

                Logger.WriteLine(new BatteryIsDeadException(this, $"Phone failed to call an ambulance: {this.PhoneName}").Message);

                throw new BatteryIsDeadException(this, $"Phone failed to call an ambulance: {this.PhoneName}");
            }
        }

        public void Charge()
        {
            this.BatteryLevel = 100;

            Logger.WriteLine($"Charging {PhoneName} to 100%");
        }

        public void ChargeABit()
        {
            this.BatteryLevel += 1;

            Logger.WriteLine($"Charging {PhoneName} by 1%");
        }
    }
}
