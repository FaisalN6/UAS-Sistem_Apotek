@extends('layout.app')
  
{{-- @section('title', 'Edit Product') --}}
  
@section('contents')
    <h1 class="mb-0">Ubah User</h1>
    <hr />
    <div class="container">
        <div class="card p-0" style="width: 80%; margin: auto; border-top: 5px solid #218CFF;">
            <div class="card-body">
                <div class="form-group">
                    <h3 class="mb-0">Form edit user</h3>
                    <hr />
                    <form action="{{ route('user.update', $user->id) }}" method="POST" enctype="multipart/form-data">
                        @csrf      
                        @method('POST')
                        {{-- Nama Obat --}}
                        <div class="col mb-3">
                            <label for="ID">ID User</label>
                            <input type="text" name="id" id="ID" class="form-control"  value="{{ $user->id }}">
                        </div>
                        {{-- /Nama Obat --}}
                        {{-- Nama Obat --}}
                        <div class="col mb-3">
                            <label for="nama">Nama User</label>
                            <input type="text" name="name" id="nama" class="form-control"  value="{{ $user->name }}">
                        </div>
                        {{-- /Nama Obat --}}
    
                        
                        {{-- Harga Obat --}}
                        <div class="col mb-3">
                            <label for="Email">Email</label>
                            <input type="text" name="email" id="Email" class="form-control"  value="{{ $user->email }}">
                        </div>

                        {{-- stok Obat --}}
                        <div class="col mb-3">
                            <label for="Password">Password</label>
                            <input type="password" name="password" id="Password" class="form-control" value="{{ $user->password }}">
                        </div>
                        {{-- /stok Obat --}}

                        {{-- stok Obat --}}
                        <div class="col mb-3">
                            <label for="Role">Role</label>
                            <input type="text" name="role" id="Role" class="form-control" value="{{ $user->role }}">
                        </div>
                        {{-- /stok Obat --}}
                        
                        {{-- /Deskripsi --}}
                            <div class="col text-right">
                                <a href="{{ route('user.view') }}" type="button" class="btn btn-secondary">Batal</a>
                                <button type="submit" class="btn btn-primary">Submit</button>
                            </div>
                    </form>
                </div>
            </div>
        </div>
        </div>
@endsection