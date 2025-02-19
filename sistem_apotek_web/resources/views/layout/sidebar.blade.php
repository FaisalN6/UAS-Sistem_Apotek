<ul class="navbar-nav sidebar sidebar-dark accordion" style="background: linear-gradient(to bottom, rgb(0, 51, 145), rgb(33, 140, 255));" id="accordionSidebar">
  <!-- Sidebar - Brand -->
  <a class="sidebar-brand d-flex align-items-center justify-content-center" href="">
    <div class="sidebar-brand-icon mx-3">
      <i class="fas fa-hospital-user"></i>
    </div>
    <div class="sidebar-brand-text">Sistem Apotek</div>
  </a>
  
  <!-- Divider -->
  <hr class="sidebar-divider bg-gradient-primary my-0">
  
  <!-- Nav Item - Dashboard -->
  <li class="nav-item">
    <a class="nav-link" href="{{ route('dashboard') }}">
      <i class="fas fa-fw fa-home"></i>
      <span>Dashboard</span></a>
  </li>
  <hr class="sidebar-divider bg-gradient-primary d-none d-md-block" >
<!-- /Nav Item - Dashboard -->

<!-- Nav Item - Daftar Obat -->
  <li class="nav-item">
    <a class="nav-link" href="{{ route('obats') }}" id="goToObats">
      <i class="fas fa-fw fa-clipboard-list"></i>
      <span>Daftar obat</span></a>
  </li>
<!-- /Nav Item - Daftar Obat -->

<!-- Nav Item - Kategori -->
  <li class="nav-item">
    <a class="nav-link" href="{{ route('kategori') }}">
      <i class="fas fa-fw fa-clipboard-list"></i>
      <span>Kategori obat</span></a>
  </li>
<!-- /Nav Item - Kategori -->

<!-- Nav Item - Suplier -->
  <li class="nav-item">
      <a class="nav-link" href="{{ route('supplier') }}">
        <i class="fas fa-fw fa-clipboard-list"></i>
        <span>Supplier</span></a>
  </li>
<!-- /Nav Item - Suplier -->

  <hr class="sidebar-divider bg-gradient-primary d-none d-md-block">

<!-- Nav Item - Laporan -->
  <li class="nav-item dropdown">
    <a href="#" class="nav-link dropdown-toggle" id="userDropdown" data-toggle="dropdown">
      <i class="fas fa-fw fa-database"></i>
      <span>Laporan</span>
    </a>
    <div class="dropdown-menu" aria-labelledby="userDropdown">
      <a class="dropdown-item" href="./laporan/laporan_transaksi">
        <i class="mr-1 text-gray-400"></i>
        <span>Laporan Transaksi</span>
      </a>
      <a class="dropdown-item" href="">
        <i class=" mr-1 text-gray-400"></i>
        <span>Stok Obat</span>
      </a>
    </div>
  </li>
<!-- /Nav Item - Laporan -->
  
<!-- Nav Item - User -->
<li class="nav-item">
  <a class="nav-link" href="{{ route('user.view') }}">
    <i class="fas fa-fw fa-user-friends"></i>
    <span>User</span></a>
</li>
<!-- /Nav Item - User -->

<!-- Nav Item - Profil -->
  {{-- <li class="nav-item">
    <a class="nav-link" href="/profile">
      <i class="fas fa-fw fa-user"></i>
      <span>Profile</span></a>
  </li> --}}
<!-- /Nav Item - Profil -->

  <!-- Divider -->
  <hr class="sidebar-divider bg-gradient-primary d-none d-md-block">
  
  <!-- Sidebar Toggler (Sidebar) -->
  <div class="text-center d-none mt-4 d-md-inline">
    <button class="rounded-circle border-0" id="sidebarToggle"></button>
  </div>
  
  
</ul>
