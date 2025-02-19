<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    {{-- <link rel="stylesheet" href="style.css"> --}}
    <title>Sistem Apotek - Login</title>
</head>

<style>
    @import url('https://fonts.googleapis.com/css2?family=Poppins:wght@400;500&display=swap');

body{
    font-family: 'Poppins', sans-serif;
    background: #ececec;
}

/*------------ Login container ------------*/

.box-area{
    width:  830px;
}

/* ------------ left box -------------- */
.left-box{
    background: linear-gradient(to bottom, rgb(0, 51, 145), rgb(33, 140, 255));
    background-size: cover;
    /* opacity: ; */
}

/*------------ Right box ------------*/
.right-box{
    padding: 40px 30px 40px 40px;
}
1

/*------------ Custom Placeholder ------------*/

::placeholder{
    font-size: 16px;
}

.rounded-4{
    border-radius: 10px;
}
.rounded-5{
    border-radius: 30px;
}


/*------------ For small screens------------*/

@media only screen and (max-width: 768px){

     .box-area{
        margin: 0 10px;

     }
     .left-box{
        height: 100px;
        overflow: hidden;
     }
     .right-box{
        padding: 20px;
     }

}
</style>
<body>

    <!----------------------- Main Container -------------------------->

     <div class="container d-flex justify-content-center align-items-center min-vh-100">

    <!----------------------- Login Container -------------------------->

       <div class="row border bg-white shadow box-area">

    <!--------------------------- Left Box ----------------------------->

       <div class="col-md-6 d-flex justify-content-center align-items-center flex-column position-relative left-box">
           <div class="container d-flex justify-content-center align-items-center flex-column ">
            <p class="text-white fs-1" style="font-family: 'Poppins'; font-weight: 400;">Sistem Apotek</p>

            {{-- <small class="text-white text-wrap text-left" style="width: 17rem;font-family: 'Courier New', Courier, monospace;">apotek yang jujur dan terpercaya seluruh Indonesia</small> --}}
        </div>
       </div> 

    <!-------------------- ------ Right Box ---------------------------->
        
       <div class="col-md-6 mt-3 right-box">
          <div class="row p-4 align-items-center">
                <div class="header-text mb-2 text-center">
                     <h2>Login</h2>
                     <p>Masukkan email dan password.</p>
                </div>
                <form action="{{ route('login.action') }}" method="POST" class="user">
                    @csrf
                    {{-- @method('POST') --}}
                    @if ($errors->any())
                    <div class="alert alert-danger">
                        <ul>
                            @foreach ($errors->all() as $error)
                                <li>{{ $error }}</li>
                            @endforeach
                        </ul>
                    </div> 
                    @endif
                    {{-- username --}}
                    <div class="form-group input-group mb-4">
                        <input name="email" type="email" class="form-control form-control-user" id="exampleInputEmail" aria-describedby="emailHelp" placeholder="Enter Email Address...">
                    </div>

                    {{-- password --}}
                    <div class="form-group input-group mb-4">
                        <input name="password" type="password" class="form-control form-control-user" id="exampleInputPassword" placeholder="Password">
                    </div>

                    {{-- remember me --}}
                    {{-- <div class="form-group input-group mb-4 d-flex justify-content-between">
                        <div class="custom-control custom-checkbox small">
                            <input name="remember" type="checkbox" class="custom-control-input" id="customCheck">
                            <label class="custom-control-label" for="customCheck">Remember
                                Me</label>
                        </div>
                    </div> --}}

                    {{-- btn login --}}
                    <div class="input-group mb-3">
                        <button type="submit" class="btn btn-lg btn-primary w-100 fs-6">Login</button>
                    </div>
                </form>
                {{-- <div class="text-center">
                    <a class="small" href="{{ route('register') }}">Create an Account!</a>
                </div> --}}
          </div>
       </div> 
       
      </div>
    </div>


    <script src="{{ asset('admin_assets/vendor/jquery-easing/jquery.easing.min.js') }}"></script>
</body>
</html>
