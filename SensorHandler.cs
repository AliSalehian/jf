using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jf
{
    class SensorHandler
    {
        private Sensor[] sensors;

        public SensorHandler()
        {
            this.sensors = new Sensor[8];
            this.sensors[0] = new Sensor("t1");
            this.sensors[1] = new Sensor("t2");
            this.sensors[2] = new Sensor("t3");
            this.sensors[3] = new Sensor("p");
            this.sensors[4] = new Sensor("mleft");
            this.sensors[5] = new Sensor("mright");
            this.sensors[6] = new Sensor("handbrake");
            this.sensors[7] = new Sensor("n");// TODO: haji erafn should ask about it
            // TODO: there is another sensor that haji erfan should ask about it
        }

        public float getSensor(string sensorName)
        {
            foreach(Sensor sensor in this.sensors)
            {
                if (sensorName.Equals(sensor.sensorName))
                {
                    return sensor.sensorValue;
                }
            }
            return 0;
        }

        public void setSensor(string sensorName, float sensorValue)
        {
            sensorName = sensorName.ToLower();
            foreach (Sensor sensor in this.sensors)
            {
                if (sensorName.Equals(sensor.sensorName.ToLower()))
                {
                    sensor.sensorValue = sensorValue;
                    break;
                }
            }
        }

        public bool checkSensorExist(string sensorName)
        {
            foreach (Sensor sensor in this.sensors)
            {
                if (sensor.sensorName.Equals(sensorName.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
