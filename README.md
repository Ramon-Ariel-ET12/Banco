# Banco
Trabajo para Duran
```mermaid

classDiagram
direction lr

class Cliente{
    +int Dni
    +string Nombre
    +string Apellido
    +double Efectivo
    +Cuenta Cuenta

    +AcreditarEfectivo(double monto)
    +DebitarEfectivo(double monto)
    +Acreditar(double monto)
    +Debitar(double monto)
    +int DevolverCBU(int dni)
    +double DevolverSaldo(int dni)
}

class Cuenta{
    -int _contador
    +int CBU
    +double Saldo

    +AcreditarSaldo(double monto) 
    +DebitarSaldo(double monto) 
}

class Emergencia{
    +Acreditar(Cliente cliente, double monto)
    +Debitar(Cliente cliente, double monto)
    +PuedeUsarme(Cliente cliente) bool
}

class Cauto{
    +Acreditar(Cliente cliente, double monto)
    +Debitar(Cliente cliente, double monto)
    +PuedeUsarme(Cliente cliente) bool
}

class Ahorrista{
    +Acreditar(Cliente cliente, double monto)
    +Debitar(Cliente cliente, double monto)
    +PuedeUsarme(Cliente cliente) bool
}

class Estado{
    <<Static>>
    +List~IEstado~ estados
    +AsignarEstado(Cliente cliente)
}

class IEstado{
    <<Interface>>
    +Acreditar(Cliente cliente, double monto)
    +Debitar(Cliente cliente, double monto)
    +PuedeUsarme(Cliente cliente) bool
}

Cuenta --* Cliente
IEstado --> Emergencia
IEstado --> Cauto
IEstado --> Ahorrista

```