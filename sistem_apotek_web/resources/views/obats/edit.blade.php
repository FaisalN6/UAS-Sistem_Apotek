@extends('layout.app')

@section('contents')
    <h1 class="mb-0">Edit Obat</h1>
    <hr />
    <div class="container">
        <div class="card p-0" style="width: 80%; margin: auto; border-top: 5px solid #218CFF;">
            <div class="card-body">
                <div class="form-group">
                    <h3 class="mb-0">Form Edit obat</h3>
                    <hr />
                    <form action="{{ route('obats.update', $obat->kd_obat) }}" method="POST">
                        @csrf
                        @method('POST')

                        <div class="form-group">
                            <label for="stock">Stok</label>
                            <input type="number" name="stock" id="stock" class="form-control" value="{{ $obat->stock }}">
                        </div>
                        <div class="form-group">
                            <label for="harga">Harga</label>
                            <input type="number" name="harga" id="harga" class="form-control" value="{{ $obat->harga }}">
                        </div>
                        <div class="form-group">
                            <label for="kd_kategori">Kode Kategori</label>
                            <input type="text" name="kd_kategori" id="kd_kategori" class="form-control" value="{{ $obat->kd_kategori }}">
                        </div>
                        <div class="form-group">
                            <label for="kd_suplier">Kode Suplier</label>
                            <input type="text" name="kd_suplier" id="kd_suplier" class="form-control" value="{{ $obat->kd_suplier }}">
                        </div>

                        <div class="col text-right">
                            <a href="{{ route('obats') }}" type="button" class="btn btn-secondary">Batal</a>
                            <button type="submit" class="btn btn-primary">Submit</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
@endsection
