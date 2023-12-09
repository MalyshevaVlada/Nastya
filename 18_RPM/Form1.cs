using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_RPM
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox2.Text != "")
			{
				string route = textBox2.Text;
				DateTime arrivalTime = dateTimePicker1.Value;
				DateTime endTime = dateTimePicker2.Value;

				if (textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "" || textBox6.Text != "")
				{
					string carDeparture = textBox3.Text;
					string carArrival = textBox4.Text;
					uint seatCount = Convert.ToUInt32(textBox5.Text);
					string carrier = textBox6.Text;

					Car car = new Car(route, arrivalTime, endTime, carDeparture, carArrival, seatCount, carrier);
					car.Инфо("Информация об автомобиле");
					return;
				}

				else if (textBox7.Text != "" || textBox8.Text != "" || textBox9.Text != "" ||
					textBox10.Text != "" || textBox11.Text != "" || textBox12.Text != "")
				{
					uint trainNumber = Convert.ToUInt32(textBox7.Text);
					string name = textBox8.Text;
					uint sittingCars = Convert.ToUInt32(textBox9.Text);
					uint reservedSeatCars = Convert.ToUInt32(textBox10.Text);
					uint compartmentCars = Convert.ToUInt32(textBox11.Text);
					uint luxuryCars = Convert.ToUInt32(textBox12.Text);

					if (textBox13.Text != "")
					{
						uint maxSpeed = Convert.ToUInt32(textBox13.Text);
						Express express = new Express(route, arrivalTime, endTime, trainNumber, name, sittingCars, reservedSeatCars, compartmentCars, luxuryCars, maxSpeed);
						express.Инфо("Информация об экспресс поезде");
						return;
					}
					else
					{
						Train train = new Train(route, arrivalTime, endTime, trainNumber, name, sittingCars, reservedSeatCars, compartmentCars, luxuryCars);
						train.Инфо("Информация о поезде");
						return;
					}
				}

				Transport transport = new Transport(route, arrivalTime, endTime);
				transport.Инфо("Информация о транспорте");
			}
		}
	}





	class Transport
	{
		protected string route;
		protected DateTime arrivalTime;
		protected DateTime endTime;
		public string message;

		public string Route
		{
			set
			{
				if (value == "") route = "???";
				else route = value;
			}
			get { return route; }
		}

		public DateTime ArrivalTime
		{
			set { arrivalTime = value; }
			get { return arrivalTime; }
		}

		public DateTime EndTime
		{
			set { endTime = value; }
			get { return endTime; }
		}

		public Transport(string route, DateTime arrivalTime, DateTime endTime)
		{
			this.route = route;
			this.arrivalTime = arrivalTime;
			this.endTime = endTime;
			message = $"Транспортное средство, следующее по маршруту {arrivalTime.ToShortTimeString()} " +
				$"отправляется в {arrivalTime.ToShortTimeString()}, прибывает в пункт назначения в {endTime.ToShortTimeString()}";
		}

		public void Инфо(string caption)
		{
			MessageBoxButtons buttons = MessageBoxButtons.OK;
			MessageBox.Show(message, caption, buttons);
		}
	}

	class Car : Transport
	{
		private string carDeparture;
		private string carArrival;
		private uint seatCount;
		private string carrier;


		public string CarDeparture
		{
			set
			{
				if (value == "") carDeparture = "???";
				carDeparture = value;
			}
			get { return carDeparture; }
		}

		public string CarArreval
		{
			set
			{
				if (value == "") carArrival = "???";
				else carArrival = value;
			}
			get { return carArrival; }
		}

		public uint SeatCount
		{
			set
			{
				try
				{
					seatCount = Convert.ToUInt32(value);
				}
				catch (FormatException)
				{
					MessageBox.Show("Отсутствует или введено некорректное значение!!!", "Ошибка");
					return;
				}
				catch (OverflowException)
				{
					MessageBox.Show("Количество мест должно быть задано положительным числом!!!", "Ошибка");
					return;
				}
			}
			get { return seatCount; }
		}

		public string Carrier
		{
			set
			{
				if (value == "") carrier = "???";
				else carrier = value;
			}
			get { return carrier; }
		}


		public Car(string route, DateTime arrivalTime, DateTime endTime, string carDeparture, string carArrival, uint seatCount, string carrier)
			: base(route, arrivalTime, endTime)
		{
			this.carDeparture = carDeparture;
			this.carArrival = carArrival;
			this.seatCount = seatCount;
			this.carrier = carrier;
			base.message += $", место отправления автомобиля - {carDeparture} , место прибытия автомобиля - {carArrival}, количество мест - {seatCount}, перевозчик - {carrier}";
		}

	}

	class Train : Transport
	{
		private uint trainNumber;
		private string name;
		private uint sittingCars;
		private uint reservedSeatCars;
		private uint compartmentCars;
		private uint luxuryCars;

		public uint TarinNumber
		{
			set
			{
				try
				{
					trainNumber = Convert.ToUInt32(value);
				}
				catch (FormatException)
				{
					MessageBox.Show("Отсутствует или введено некорректное значение!!!", "Ошибка");
					return;
				}
				catch (OverflowException)
				{
					MessageBox.Show("Номер поезда должен быть задан положительным числом!!!", "Ошибка");
					return;
				}
			}
			get { return trainNumber; }
		}

		public string Name
		{
			set
			{
				if (value == "") name = "???";
				name = value;
			}
			get { return name; }
		}

		public uint SittingCars
		{
			set
			{
				try
				{
					sittingCars = Convert.ToUInt32(value);
				}
				catch (FormatException)
				{
					MessageBox.Show("Отсутствует или введено некорректное значение!!!", "Ошибка");
					return;
				}
				catch (OverflowException)
				{
					MessageBox.Show("Количество вагонов должно быть заданно положительным числом!!!", "Ошибка");
					return;
				}
			}
			get { return sittingCars; }
		}

		public uint ReservedSeatCars
		{
			set
			{
				try
				{
					reservedSeatCars = Convert.ToUInt32(value);
				}
				catch (FormatException)
				{
					MessageBox.Show("Отсутствует или введено некорректное значение!!!", "Ошибка");
					return;
				}
				catch (OverflowException)
				{
					MessageBox.Show("Количество вагонов должно быть заданно положительным числом!!!", "Ошибка");
					return;
				}
			}
			get { return reservedSeatCars; }
		}

		public uint CompartmentCars
		{
			set
			{
				try
				{
					compartmentCars = Convert.ToUInt32(value);
				}
				catch (FormatException)
				{
					MessageBox.Show("Отсутствует или введено некорректное значение!!!", "Ошибка");
					return;
				}
				catch (OverflowException)
				{
					MessageBox.Show("Количество вагонов должно быть заданно положительным числом!!!", "Ошибка");
					return;
				}
			}
			get { return compartmentCars; }
		}

		public uint LuxuryCars
		{
			set
			{
				try
				{
					luxuryCars = Convert.ToUInt32(value);
				}
				catch (FormatException)
				{
					MessageBox.Show("Отсутствует или введено некорректное значение!!!", "Ошибка");
					return;
				}
				catch (OverflowException)
				{
					MessageBox.Show("Количество вагонов должно быть заданно положительным числом!!!", "Ошибка");
					return;
				}
			}
			get { return luxuryCars; }
		}

		public Train(string route, DateTime arrivalTime, DateTime endTime,
			uint trainNumber, string name, uint sittingCars, uint reservedSeatCars, uint compartmentCars, uint luxuryCars)
			: base(route, arrivalTime, endTime)
		{
			this.trainNumber = trainNumber;
			this.name = name;
			this.sittingCars = sittingCars;
			this.reservedSeatCars = reservedSeatCars;
			this.compartmentCars = compartmentCars;
			this.luxuryCars = luxuryCars;

			base.message += $", является поездом №{trainNumber} {name}, с количеством вагонов: сидячих - {sittingCars}, плацкартных - {reservedSeatCars}, купейных - {compartmentCars}, \"Люкс\"/мягких - {luxuryCars}";
		}
	}

	class Express : Train
	{
		private uint maxSpeed;

		public uint MaxSpeed
		{
			set
			{
				try
				{
					maxSpeed = Convert.ToUInt32(value);
				}
				catch (FormatException)
				{
					MessageBox.Show("Отсутствует или введено некорректное значение!!!", "Ошибка");
					return;
				}
				catch (OverflowException)
				{
					MessageBox.Show("Максимальная скорость должна быть задана положительным числом!!!", "Ошибка");
					return;
				}
			}
			get { return maxSpeed; }
		}

		public Express(string route, DateTime arrivalTime, DateTime endTime,
			uint trainNumber, string name, uint sittingCars, uint reservedSeatCars, uint compartmentCars, uint luxuryCars, uint maxSpeed)
			: base(route, arrivalTime, endTime, trainNumber, name, sittingCars, reservedSeatCars, compartmentCars, luxuryCars)
		{
			this.maxSpeed = maxSpeed;
			base.message += $", относится к типу скоростных (высокоскоростных) поездов с развиваемой скоростья до {maxSpeed} км/ч и используется как экспресс";
		}
	}
}
