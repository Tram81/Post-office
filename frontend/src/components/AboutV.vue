<template>
    <section class="contact_section layout_padding">
    <div class="d-flex justify-content-center">
      <h2 class="heading_style">
        Contact us
      </h2>
    </div>
    <div class="container layout_padding2-top">
      <div class="row">
        <div class="col-md-6">
          <div id="map" class="w-100 h-100"></div>
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
                <!-- <button type="submit " class="">
                  Send
                </button> -->
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
              Quản lí bưu điện
            </span>
          </div>
          <p>
            Niềm vui của bạn là hạnh phúc của chúng tôi
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
            Địa chỉ
          </h5>
          <p>
            285 Đội Cấn, Hà Nội, Việt Nam
          </p>
          <p>
            (+84) 123456789
          </p>
          <p>
            (+84) 123456789
          </p>
          <p>
            <a href="">
              quanlibuudien@gmail.com
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
</template>

<style scoped>
@import url("@/assets/css/responsive.css");
@import url("@/assets/css/bootstrap.css");
@import url("@/assets/css/style.css");
</style>