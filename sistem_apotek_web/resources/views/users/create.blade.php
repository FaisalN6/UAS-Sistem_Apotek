@extends('layout.app')
  
{{-- @section('title', 'Tambah Obat') --}}

@section('contents')
    <h1 class="mb-0">Tambah User</h1>
    <hr />
    <div class="container">
    <div class="card p-0" style="width: 80%; margin: auto; border-top: 5px solid #218CFF;">
        <div class="card-body">
            <div class="form-group">
                <h3 class="mb-0">Form tambah user</h3>
                <hr />
                <form action="{{ route('user.store') }}" method="POST" enctype="multipart/form-data">
                    @csrf      
                    {{-- Nama Obat --}}
                    {{-- <div class="col mb-3">
                        <label for="Id">ID User</label>
                        <input type="text" name="id" id="Id" class="form-control" placeholder="ID User  ">
                    </div> --}}
                    {{-- /Nama Obat --}}
                    {{-- Nama Obat --}}
                    <div class="col mb-3">
                        <label for="Name">Nama</label>
                        <input type="text" name="name" id="Name" class="form-control" placeholder="Nama User">
                    </div>
                    {{-- /Nama Obat --}}

                    {{-- Email --}}
                    <div class="col mb-3">
                        <label for="Email">Email</label>
                        <input type="text" name="email" id="Email" class="form-control" placeholder="Email">
                    </div>
                    {{-- /Email --}}
                    
                    {{-- Password --}}
                    <div class="col mb-3">
                        <label for="Password">Password</label>
                        <input type="password" name="password" id="Password" class="form-control" placeholder="Password">
                    </div>
                    {{-- /Password --}}
                    
                    {{-- Rolw --}}
                    <div class="col mb-3">
                        <label for="Role">Role</label>
                        <input type="text" name="role" id="Role" class="form-control" placeholder="">
                    </div>
                    {{-- /Role --}}

                        <div class="col text-right">
                            {{-- <button type="submit" class="btn btn-secondary">Batal</button> --}}
                            <a href="{{ route('user.view') }}" type="button" class="btn btn-secondary">Batal</a>
                            <button type="submit" class="btn btn-primary">Submit</button>
                        </div>
                </form>
            </div>
        </div>
    </div>
    </div>
@endsection