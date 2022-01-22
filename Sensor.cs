using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jf
{
    class Sensor
    {
        public string sensorName { get; set; }
        public float sensorValue { get; set; }
        public Sensor(string sensorName)
        {
            this.sensorName = sensorName;
        }

        public Sensor(string sensorName, float sensorValue)
        {
            this.sensorName = sensorName;
            this.sensorValue = sensorValue;
        }
    }
}
