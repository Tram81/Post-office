<template>
    
    <!-- <div class="home">
        <h1>Welcome to Home Page</h1>
        <p>This is a simple home page built with Vue 3.</p>
    </div> -->

    <section class="about_section ">
    <div class="container">
      <div class="row">
        <div class="col">
          <h2 class="heading_style">
            About Us
          </h2>
          <p>
            adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
            quis nostrud exercitation ullamco
          </p>
        </div>

      </div>
      <div class="row">
        <div class="col-md-6">
          <div class="about_img-box">

            <img src="images/a-truck.jpg" alt="" class="img-fluid">
          </div>
        </div>
        <div class="col-md-6 about_detail-container">
          <div class="about_detail-box">
            <h3>
              Company and Transport
            </h3>
            <p>
              Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et
              dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex
              ea commodo consequat. Duis aute irure dolor in reprehenderit in Lorem ipsum dolor sit amet, consectetur
              adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna as
            </p>
            <div class="d-flex  justify-content-end">
              <a href="" class="quote-btn about-btn">
                <img src="images/white-next.png" alt="">
                <span>
                  About More
                </span>

              </a>
            </div>
          </div>
        </div>
      </div>
    </div>

  </section>

  <!-- end about section -->

  <!-- service section -->
  <section class="service_section layout_padding">
    <div class="container">
      <div class="d-flex justify-content-center">
        <h2 class="heading_style">
          Our Services
        </h2>
      </div>
      <div class="row layout_padding2-top">
        <div class="col-md-4">
          <div class="service_img-box s-b-1">
            <img src="images/service-1.jpg" alt="">
            <div class="d-flex">
              <h3>
                CARGO

              </h3>
            </div>
          </div>
          <div class="service-detail">
            <p>
              aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum
              dolore eu fugiat nulla pariatur.Excepteur
            </p>
            <div class="d-flex justify-content-end">
              <a href="" class="service-btn">
                See More
              </a>
            </div>
          </div>
        </div>
        <div class="col-md-4">
          <div class="service_img-box s-b-2">
            <img src="images/service-2.jpg" alt="">
            <div class="d-flex">
              <h3>
                LOGISTIC SERVICE


              </h3>
            </div>
          </div>
          <div class="service-detail">
            <p>
              aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum
              dolore eu fugiat nulla pariatur.Excepteur
            </p>
            <div class="d-flex justify-content-end">
              <a href="" class="service-btn">
                See More
              </a>
            </div>
          </div>
        </div>
        <div class="col-md-4">
          <div class="service_img-box s-b-3">
            <img src="images/service-3.jpg" alt="">
            <div class="d-flex">
              <h3>
                STORAGE


              </h3>
            </div>
          </div>
          <div class="service-detail">
            <p>
              aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum
              dolore eu fugiat nulla pariatur.Excepteur
            </p>
            <div class="d-flex justify-content-end">
              <a href="" class="service-btn">
                See More
              </a>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- end service section -->


  <!-- shop section -->
  <section class="shop_section">
    <div class="container">
      <div class="d-flex justify-content-center">
        <h2 class="heading_style">
          Our Shop
        </h2>
      </div>
      <div class="row">
        <div class="col-md-6">
          <div class="d-flex align-items-center h-100">
            <div class="shop-detail">
              <h5>
                Everything You Need
              </h5>
              <p>
                ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore
                magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip
              </p>
            </div>
          </div>
        </div>
        <div class="col-md-6">
          <div class="shop_img-box">
            <img src="images/gift.jpg" alt="" class="img-fluid">
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- end shop section -->

  <!-- testimonial section -->
  <section class="client_section layout_padding">
    <div class="d-flex justify-content-center">
      <h2 class="heading_style">
        Testimonial
      </h2>
    </div>
    <div id="carouselExampleIndicator" class="carousel slide" data-ride="carousel">
      <ol class="carousel-indicators">
        <li data-target="#carouselExampleIndicator" data-slide-to="0" class="active"></li>
        <li data-target="#carouselExampleIndicator" data-slide-to="1"></li>
        <li data-target="#carouselExampleIndicator" data-slide-to="2"></li>
        <li data-target="#carouselExampleIndicator" data-slide-to="3"></li>
      </ol>
      <div class="carousel-inner">
        <div class="carousel-item active">
          <div class="container">
            <div class="row">
              <div class="col-md-6">
                <div class="client_box c-b-1">
                  <div class="client_img">
                    <img src="images/client.png" alt="" class="img-fluid">
                  </div>
                  <div class="client_detail">
                    <h5>
                      Rock lu
                    </h5>
                    <p>
                      Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of
                      classical
                      Latin literature from 45 BC, making it over 2000 years
                    </p>
                  </div>
                </div>
              </div>
              <div class="col-md-6">
                <div class="client_box c-b-2">
                  <div class="client_img">
                    <img src="images/client.png" alt="" class="img-fluid">
                  </div>
                  <div class="client_detail">
                    <h5>
                      Rock lu
                    </h5>
                    <p>
                      Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of
                      classical
                      Latin literature from 45 BC, making it over 2000 years
                    </p>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="carousel-item">
          <div class="container">
            <div class="row">
              <div class="col-md-6">
                <div class="client_box c-b-1">
                  <div class="client_img">
                    <img src="images/client.png" alt="" class="img-fluid">
                  </div>
                  <div class="client_detail">
                    <h5>
                      Rock lu
                    </h5>
                    <p>
                      Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of
                      classical
                      Latin literature from 45 BC, making it over 2000 years
                    </p>
                  </div>
                </div>
              </div>
              <div class="col-md-6">
                <div class="client_box c-b-2">
                  <div class="client_img">
                    <img src="images/client.png" alt="" class="img-fluid">
                  </div>
                  <div class="client_detail">
                    <h5>
                      Rock lu
                    </h5>
                    <p>
                      Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of
                      classical
                      Latin literature from 45 BC, making it over 2000 years
                    </p>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="carousel-item">
          <div class="container">
            <div class="row">
              <div class="col-md-6">
                <div class="client_box c-b-1">
                  <div class="client_img">
                    <img src="images/client.png" alt="" class="img-fluid">
                  </div>
                  <div class="client_detail">
                    <h5>
                      Rock lu
                    </h5>
                    <p>
                      Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of
                      classical
                      Latin literature from 45 BC, making it over 2000 years
                    </p>
                  </div>
                </div>
              </div>
              <div class="col-md-6">
                <div class="client_box c-b-2">
                  <div class="client_img">
                    <img src="images/client.png" alt="" class="img-fluid">
                  </div>
                  <div class="client_detail">
                    <h5>
                      Rock lu
                    </h5>
                    <p>
                      Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of
                      classical
                      Latin literature from 45 BC, making it over 2000 years
                    </p>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="carousel-item">
          <div class="container">
            <div class="row">
              <div class="col-md-6">
                <div class="client_box c-b-1">
                  <div class="client_img">
                    <img src="images/client.png" alt="" class="img-fluid">
                  </div>
                  <div class="client_detail">
                    <h5>
                      Rock lu
                    </h5>
                    <p>
                      Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of
                      classical
                      Latin literature from 45 BC, making it over 2000 years
                    </p>
                  </div>
                </div>
              </div>
              <div class="col-md-6">
                <div class="client_box c-b-2">
                  <div class="client_img">
                    <img src="images/client.png" alt="" class="img-fluid">
                  </div>
                  <div class="client_detail">
                    <h5>
                      Rock lu
                    </h5>
                    <p>
                      Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of
                      classical
                      Latin literature from 45 BC, making it over 2000 years
                    </p>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>

    </div>

  </section>
  <!-- end testimonial section -->



  <!-- company section -->
  <section class="company_section layout_padding2">
    <div class="container">
      <div class="row">
        <div class="col-md-6">
          <div class="d-flex align-items-center h-100">
            <div class="company-detail">
              <h3>
                Company
              </h3>
              <p>
                Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical
                Latin literature from 45 BC, making it over 2000 yearsContrary to popular belief, Lorem Ipsum is not
                simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over
                2000 years
              </p>
            </div>
          </div>
        </div>
        <div class="col-md-6">
          <div class="company_img-box">
            <img src="images/company.jpg" alt="" class="img-fluid">
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- end company section -->



  <!-- contact section -->
  <section class="contact_section layout_padding">
    <div class="d-flex justify-content-center">
      <h2 class="heading_style">
        Contact us
      </h2>
    </div>
    <div class="container layout_padding2-top">
      <div class="row">
        <div class="col-md-6">
          <div id="map" class="h-100 w-100"></div>
        </div>

        <div class="col-md-6">
          <div class="contact_form-container">
            <form action="">
              <div>
                <input type="text" placeholder="Your Name">
              </div>
              <div>
                <input type="email" placeholder="Your Email">
              </div>
              <div>
                <input type="text" placeholder="Your Phone">
              </div>

              <div>
                <input type="text" class="message_input" placeholder="Message">
              </div>
              <div class="d-flex justify-content-end">
                <button type="submit " class="">
                  Send
                </button>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- end contact section -->



  <!-- info section -->
  <section class="info_section ">
    <div class="container ">
      <div class="row  mb-3 pb-4">
        <div class="col-md-3 info_logo">
          <div class="logo-box">
            <img src="images/logo-white.png" alt="">
            <span>
              Transportz
            </span>
          </div>
          <p>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sedconsectetur
          </p>
          <div class="info_social">
            <div>
              <a href="">
                <img src="images/fb.png" alt="">
              </a>
            </div>
            <div>
              <a href="">
                <img src="images/twitter.png" alt="">
              </a>
            </div>
            <div>
              <a href="">
                <img src="images/g-plus.png" alt="">
              </a>
            </div>
            <div>
              <a href="">
                <img src="images/linkedin.png" alt="">
              </a>
            </div>
          </div>
        </div>
        <div class="col-md-3 info_address">
          <h5>
            Address
          </h5>
          <p>
            Healing Center, 176 W Street name,
            New York, NY 10014, US
          </p>
          <p>
            (+71) 8522369417
          </p>
          <p>
            (+71) 8522369417
          </p>
          <p>
            <a href="">
              transportz@gmail.com
            </a>
          </p>
        </div>
        <div class="col-md-3 info_links">

          <div class="info_nav ">
            <nav class="">
              <ul>
                <h5>
                  Links
                </h5>
                <li>
                  <a href="index.html"> Home</a>
                </li>
                <li>
                  <a href="about.html">About</a>
                </li>
                <li>
                  <a href="service.html"> Service</a>
                </li>
                <li>
                  <a href="shop.html"> Shop</a>
                </li>
                <li>
                  <a href="company.html"> Company</a>
                </li>
                <li>
                  <a href="contact.html">Contact us</a>
                </li>

              </ul>
            </nav>
          </div>
        </div>
        <div class="col-md-3 info_news">
          <h5>
            Newsletter
          </h5>
          <form action="">
            <div>
              <input type="text" placeholder="Your Name">
            </div>
            <div>
              <input type="email" placeholder="Email">
            </div>
            <div class="d-flex justify-content-end">
              <button type="submit">
                Subscribe
              </button>
            </div>
          </form>
        </div>
      </div>


    </div>
  </section>
  <!-- end info section -->

  <!-- footer section -->
  <section class="container-fluid footer_section">
    <p>
      Copyright &copy; 2019 All Rights Reserved By
      <a href="https://html.design/">Free Html Templates</a>
    </p>
  </section>
</template>

<script>
export default {
    methods: {
        logout() {
            // Xử lý đăng xuất ở đây
            // Ví dụ: xóa token khỏi Local Storage và chuyển hướng đến trang đăng nhập
            localStorage.removeItem('token');
            this.$router.push('/login');
            window.location.reload();
        }
    }
};
</script>

<style scoped>
@import url("@/assets/css/responsive.css");
@import url("@/assets/css/bootstrap.css");
@import url("@/assets/css/style.css");
</style>
