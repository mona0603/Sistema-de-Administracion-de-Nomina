namespace SistemaDeAdministracionDeNomina.Design
{
    /// <summary>
    /// Identifica de forma abstracta cada uno de los 4 módulos principales
    /// del sidebar de DATACAPTURE. Sirve para que INTERFACE pueda indicar
    /// "abre DATACAPTURE en este módulo" sin necesitar acceso directo a
    /// los controles privados d_uC_Modules1..4.
    ///
    /// Nota: existen otras 2 opciones reservadas para otra cosa (aún sin
    /// formulario), que NO forman parte del sidebar de DATACAPTURE y por
    /// lo tanto no están en este enum.
    /// </summary>
    public enum ModuleType
    {
        Employees,
        Catalogue,
        Concepts,
        PayrollCapture,
    }
}