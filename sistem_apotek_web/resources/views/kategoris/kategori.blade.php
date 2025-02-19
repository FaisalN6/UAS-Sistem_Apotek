@extends('layout.app')

@section('contents')
<div class="d-flex align-items-center justify-content-between">
    <h1 class="mb-0">Kategori Obat</h1>
    <a href="{{ route('kategoris.create') }}" class="btn btn-primary">Tambah Kategori</a>
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
                        <th>Kode Kategori</th>
                        <th>Nama Kategori</th>
                        <th class="text-center">Action</th>
                    </tr>
                </thead>
                <tbody>
                    @if(count($kategori) > 0)
                        @foreach($kategori as $rs)
                            <tr>
                                <td class="align-middle">{{ $loop->iteration }}</td>
                                <td class="align-middle">{{ $rs->kd_kategori }}</td>
                                <td class="align-middle">{{ $rs->nama_kategori }}</td>
                                <td class="d-flex justify-content-center align-content-center">
                                    <div class="btn" role="group" aria-label="Basic example" >
                                        <a href="{{ route('kategoris.edit', $rs->kd_kategori) }}" type="button" class="btn btn-warning " style="font-weight: bold;">Edit</a>
                                        <form action="{{ route('kategoris.destroy', $rs->kd_kategori) }}" method="POST" class="btn p-0" onsubmit="return confirm('Delete?')">
                                            @csrf
                                            @method('DELETE')
                                            <button class="btn btn-danger m-0" style="font-weight: bold;">Delete</button>
                                        </form>    
                                    </div>
                                </td>
                            </tr>
                        @endforeach
                    @else
                        <tr>
                            <td class="text-center" colspan="9">Kategori tidak ditemukan!</td>
                        </tr>
                    @endif
                </tbody>
            </table>
        </div>
    </div>
</div>
@endsection
