using System;
using System.Collections.Generic;
using Firebase.Database;
using System.Text;

namespace MVVM_implementacion_AGGP.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmaggp-default-rtdb.firebaseio.com/");
    }
}
