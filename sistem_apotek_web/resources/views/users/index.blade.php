@extends('layout.app')

@section('contents')
<div class="d-flex align-items-center justify-content-between">
    <h1 class="mb-0">User</h1>
    <a href="{{ route('user.create') }}" class="btn btn-primary">Tambah User</a>
</div>
<hr />
@if(Session::has('success'))
    <div class="alert alert-success" role="alert">
        {{ Session::get('success') }}
    </div>
@endif
<!-- Recent Orders -->
<div class="card">
    <div class="card-body">
        <div class="table-responsive">
            <table class="table table-hover">
                <thead class="datatable table table-hover table-center mb-0">
                    <tr>
                        <th>#</th>
                        <th>Kode User</th>
                        <th>Nama User</th>
                        <th>Email</th>
                        <th>Password</th>
                        <th>Role</th>
                        <th class="text-center">Action</th>
                    </tr>
                </thead>
                <tbody>
                    @if(count($user) > 0)
                        @foreach($user as $rs)
                            <tr>
                                <td class="align-middle">{{ $loop->iteration }}</td>
                                <td class="align-middle">{{ 'KD-0' . $rs->id }}</td>
                                <td class="align-middle">{{ $rs->name }}</td>
                                <td class="align-middle">{{ $rs->email }}</td>
                                <td class="align-middle">{{ $rs->password }}</td>
                                <td class="align-middle">{{ $rs->role }}</td>
                                <td class="d-flex justify-content-center align-content-center">
                                    <div class="btn" role="group" aria-label="Basic example" >
                                        <a href="{{ route('user.edit', $rs->id) }}" type="button" class="btn btn-warning " style="font-weight: bold;">Ubah</a>
                                        <form action="{{ route('user.destroy', $rs->id) }}" method="POST" type="button" class="btn btn--danger p-0" onsubmit="return confirm('Apakah data ingin dihapus?')">
                                            @csrf
                                            @method('DELETE')
                                            <button class="btn btn-danger m-0" style="font-weight: bold;">Hapus</button>
                                        </form>    
                                    </div>
                                </td>
                            </tr>
                        @endforeach
                    @else
                        <tr>
                            <td class="text-center" colspan="9">Supplier tidak ditemukan</td>
                        </tr>
                    @endif
                </tbody>
            </table>
        </div>
    </div>
</div>
@endsection
