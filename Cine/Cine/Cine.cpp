// Cine.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include "pch.h"
#include <iostream>
using namespace std;

int main()
{



	struct cliente {

		string nombre;
		int no_documento;
		int telefono;
		string direccion;
		void rc()//registrar cliente
		{
			cout << "\nNombre: ";
			cin >> nombre;
			cout << "\nNumero de documento ";
			cin >> no_documento;
			cout << "\nTelefono ";
			cin >> telefono;
			cout << "\nDireccion ";
			cin >> direccion;

		};
		void vc();//visualizar

	};
	struct vehiculo {
		unsigned int id_vehiculo;
		string placa;
		string marca;
		string referencia;
		int precio;
		void rv();//registrar
		void vv();//visualizar
		vehiculo() {
			id_vehiculo = 0;
		}
	};
	struct venta {
		unsigned int id_venta;
		int no_local;
		string fecha;
		int precio_total;

		void rve(cliente, vehiculo);//registrar
		void vve(cliente, vehiculo);//visualizar
		venta() {
			id_venta = 0;
		}
	};


	
	void cliente::vc()//visualizar cliente
	{
		cout << "\nNombre: " << nombre;
		cout << "\nNumero de documento: " << no_documento;
		cout << "\nTelefono: " << telefono;
		cout << "\nDireccion: " << direccion;
	};
	void vehiculo::rv()
	{     //registrar vehiculo
		id_vehiculo = id_vehiculo + 1
			cout << "\nID: ";
		cout << "\nPlaca: ";
		cin >> placa;
		cout << "\nMarca: ";
		cin >> marca;
		cout << "\nReferencia: ";
		cin >> referencia;
		cout << "\nPrecio: ";
		cin >> precio;

	};

	void vehiculo::vv()//visualizar vehiculo
	{
		cout << "\nID: " << id_vehiculo;
		cout << "\nPlaca: " << placa;
		cout << "\nMarca: " << marca;
		cout << "\nReferencia: " << referencia;
		cout << "\nPrecio: " << precio;


	};
	void venta::rve(cliente x, vehiculo y)//registrar venta 
	{
		cout << "\nLocal: ";
		cin >> no_local;
		cout << "\nFecha: ";
		cin >> fecha;
		int valora;
		cout << "Valores adicionales";
		cin >> valora;

		precio_total = precio + valora;
		cout << "\nMonto total: " << precio_total;


		cout << "\n\nDatos del cliente\n";
		cout << "\nNombre: " << nombre;
		cout << "\nNumero de documento: " << no_documento;
		cout << "\nTelefono: " << telefono;
		cout << "\nDireccion: " << direccion;

		cout << "\n\nDatos del vehiculo\n";
		cout << "\nPlaca: " << placa;
		cout << "\nMarca: " << marca;
		cout << "\nReferencia: " << referencia;
		cout << "\nPrecio: " << precio;
	};
	void venta::vve(cliente x, vehiculo y) {//visualizar venta
		cout << "\nLocal: ";
		cout << "\nFecha: ";
		cout << "\nMonto total: ";


		cout << "\n\nDatos del cliente\n";
		cout << "\nNombre: " << nombre;
		cout << "\nNumero de documento: " << no_documento;
		cout << "\nTelefono: " << telefono;
		cout << "\nDireccion: " << direccion;

		cout << "\n\nDatos del vehiculo\n";
		cout << "\nPlaca: " << placa;
		cout << "\nMarca: " << marca;
		cout << "\nReferencia: " << referencia;
		cout << "\nPrecio: " << precio;
	};




	int main()
	{
		int c = 1, v = 1, ve = 1;
		cliente listac[c];
		vehiculo listav[v];
		venta listave[ve];

		int op, sal = 1;
		do {
			cout << "Venta automoviles \nMenu:\n1.Registrar auto\n2.Visualizar auto\n3.Registrar venta\n4.Visualizar venta";
			do {
				cout << "\nDigite una opcion del menu: ";
				cin >> op;
			} while (op < 1 || op>8);
			switch (op)
			{
			case 1:
			{cout << "1.Registrar auto";

			listav[v].rv();
			v = v + 1;
			cout << "\nSalir=0\n Otra opcion del menC:: Cualquier tecla";
			cin >> sal;
			break;
			}
			case 2:
			{
				cout << "2.Visualizar auto";
				cout << "\nDigite numero de auto: ";
				cin >> v;
				listav[v].vv();

				cout << "\nSalir=0\n Otra opcion del menC:: Cualquier tecla";
				cin >> sal;
				break;
			}
			case 3:
			{
				cout << "3.Registrar venta";
				int reg;
				do {
					cout << "\n¿el cliente está registrado?\n1.si\n2.no";
					cin >> reg;
				} while (reg < 1 || reg>2);
				if (reg == 2) {
					listac[c].rc();
				}

				listave[ve].rve();

				ve = ve + 1;
				cout << "\nSalir=0\n Otra opcion del menC:: Cualquier tecla";
				cin >> sal;
				break;
			}
			case 4:
			{
				cout << "4.Visualizar venta";

				cout << "\nDigite numero de venta a visualizar: ";
				cin >> ve;
				listave[ve].vve();

				cout << "\nSalir=0\n Otra opcion del menC:: Cualquier tecla";
				cin >> sal;
				break;
			}

			}

		} while (sal != 0);
		return 0;
	}
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
