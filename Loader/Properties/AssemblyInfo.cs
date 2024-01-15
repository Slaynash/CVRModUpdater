using MelonLoader;
using System.Reflection;
using System.Runtime.InteropServices;
using CVRModUpdater.Loader;

// Les informations générales relatives à un assembly dépendent de
// l'ensemble d'attributs suivant. Changez les valeurs de ces attributs pour modifier les informations
// associées à un assembly.
[assembly: AssemblyTitle("CVRModUpdater.Loader")]
[assembly: AssemblyDescription("Automatic mod updater plugin for ChilloutVR, using MelonLoader")]
[assembly: AssemblyCompany("ChilloutVR Modding Group")]
[assembly: AssemblyProduct("CVRModUpdater")]
[assembly: AssemblyCopyright("Copyright © Slaynash 2022")]

// L'affectation de la valeur false à ComVisible rend les types invisibles dans cet assembly
// aux composants COM. Si vous devez accéder à un type dans cet assembly à partir de
// COM, affectez la valeur true à l'attribut ComVisible sur ce type.
[assembly: ComVisible(false)]

// Le GUID suivant est pour l'ID de la typelib si ce projet est exposé à COM
[assembly: Guid("673205c7-6ed1-4cdc-9bce-3042ee819276")]

// Les informations de version pour un assembly se composent des quatre valeurs suivantes :
//
//      Version principale
//      Version secondaire
//      Numéro de build
//      Révision
//
// Vous pouvez spécifier toutes les valeurs ou indiquer les numéros de build et de révision par défaut
// en utilisant '*', comme indiqué ci-dessous :
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: MelonInfo(typeof(CVRModUpdaterPlugin), "CVRModUpdater.Loader", CVRModUpdaterPlugin.VERSION, "Nirvash, Slaynash")]
[assembly: MelonGame("Alpha Blend Interactive", "ChilloutVR")]

// ModLoadSeparator runs before us and we need to be first, otherwise it tries loading mods that 
// we may have moved to the Broken folder
[assembly: MelonPriority(int.MinValue)]
