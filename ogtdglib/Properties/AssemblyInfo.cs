﻿using System.Reflection;
using System.Runtime.InteropServices;

//using System.Runtime.CompilerServices;

// Общие сведения об этой сборке предоставляются следующим набором
// набора атрибутов. Измените значения этих атрибутов, чтобы изменить сведения,
// связанные со сборкой.
[assembly: AssemblyTitle("OgtDgLib")]
[assembly: AssemblyDescription("OgtDgLib")]
//[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("OnGoTeam")]
[assembly: AssemblyProduct("ogtdglib")]
[assembly: AssemblyCopyright("Copyright © 2019 OGT")]
//[assembly: AssemblyTrademark("")]
//[assembly: AssemblyCulture("")]

// Установка значения False для параметра ComVisible делает типы в этой сборке невидимыми
// для компонентов COM. Если необходимо обратиться к типу в этой сборке через
// COM, задайте атрибуту ComVisible значение TRUE для этого типа.
[assembly: ComVisible(false)]

// Следующий GUID служит для идентификации библиотеки типов, если этот проект будет видимым для COM
[assembly: Guid("6dc4a171-d8fe-4ae9-9669-a82cac939ce4")]

// Сведения о версии сборки состоят из следующих четырех значений:
//
//      Основной номер версии
//      Дополнительный номер версии
//   Номер сборки
//      Редакция
//
// Можно задать все значения или принять номер сборки и номер редакции по умолчанию.
// используя "*", как показано ниже:
// [assembly: AssemblyVersion("1.0.*")]
// RELEASE: main.additional(concat)revision.*
// DEBUG: main.additional.*
// revision is exactly two symbols
#if DEBUG
    [assembly: AssemblyVersion("0.102.*")]
#else
[assembly: AssemblyVersion("0.1.2.0")]
#endif