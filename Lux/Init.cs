// ────── ╔╗
// ╔═╦╦═╦╦╬╣ Init.cs
// ║║║║╬║╔╣║ <<TODO>>
// ╚╩═╩═╩╝╚╝ ───────────────────────────────────────────────────────────────────────────────────────
using System.Reflection;
namespace Nori;

public class Lux2 {
   public static void Init () {      
      if (!sInited) { 
         sInited = true;
         VNode.RegisterAssembly (Assembly.GetExecutingAssembly ());
      }
   }

   public static void DeInit () {
      Lux.ShutDown (); 
      sInited = false;
   }

   public static bool IsRunning => sInited;

   static bool sInited;
}
