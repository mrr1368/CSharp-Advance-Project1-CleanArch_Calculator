🚀 پروژه ماشین‌حساب با معماری تمیز (Clean Architecture)

سلام! 😎 خوش اومدید به پروژه من! اینجا یه ماشین‌حساب داریم که با اصول معماری تمیز (Clean Architecture) پیاده‌سازی شده و به صورت گام به گام با استفاده از مفاهیم Dependency Injection، SOLID Principles و Responsibility Segregation ساخته شده.

🌟 مقدمه

هدف من از این پروژه این بود که اصول پایه‌ای برنامه‌نویسی و مفاهیم مهم معماری نرم‌افزار رو تو یک فضای ساده و مینیمال تمرین کنم. برام خیلی جذاب بود که این اصول رو در عمل و تو یه پروژه کوچک پیاده‌سازی کنم. البته، این مسیر بدون چالش نبوده! زمان زیادی از من گرفته شد و بارها به بن‌بست رسیدم، اما هر بار که پیش رفتم، چیزهای جدیدی یاد گرفتم که برای من خیلی ارزشمند بود.


🏗️ معماری پروژه
این پروژه از معماری Clean Architecture پیروی می‌کنه و شامل سه لایه اصلی هست:

لایه دامین: منطق اصلی و تجاری پروژه، مسئول پردازش و محاسبات.

لایه اپلیکیشن: این لایه مسئول برقراری ارتباط بین لایه‌های مختلف پروژه است.

لایه یو آی: نمایش اطلاعات به کاربر و مسئول تعامل با او.

در این پروژه هیچ لایه‌ای به نام "پریزنتیشن" نداریم و تمام فرآیندها در لایه‌های دیگه انجام میشه. این کار باعث شده که پروژه ساده‌تر و با پیچیدگی کمتری روبرو بشه.


💡 چالش‌ها و یادگیری‌ها

در طول توسعه پروژه با چالش‌های زیادی روبرو شدم که بعضی از مهم‌ترینش‌ها عبارتند از:

تزریق وابستگی (Dependency Injection): یاد گرفتن نحوه پیاده‌سازی این مفهوم در کلاس‌ها.

معماری تمیز: چطور میشه این معماری رو درست در پروژه پیاده‌سازی کرد.

ایونت‌ها و مدیریت خطاها: استفاده از ایونت‌ها و کلاس‌های استثنا برای مدیریت خطاها.

ساختار مناسب برای ورودی‌ها و خروجی‌ها: طراحی و پیاده‌سازی ساختاری که کار با ورودی‌ها و خروجی‌ها رو ساده کنه.

این چالش‌ها باعث شدن که هر روز چیزهای جدید یاد بگیرم و در نتیجه پیشرفت زیادی داشته باشم. تمام این‌ها برای من یک گام بزرگ در مسیر یادگیری برنامه‌نویسی و معماری نرم‌افزار بود.


🎯 چرا این پروژه رو ساختم؟

در این پروژه، هدف من این بود که:

با اصول معماری تمیز آشنا بشم.

از Dependency Injection و SOLID Principles استفاده کنم.

بهترین شیوه‌های برنامه‌نویسی رو در یک محیط ویندوز فرم پیاده‌سازی کنم.

تمرین کنم در مستندسازی کد و کامنت‌گذاری XML.

با این پروژه می‌خواستم نشون بدم که حتی یه ماشین‌حساب ساده هم می‌تونه با اصول طراحی نرم‌افزار بهینه ساخته بشه.


🔧 ویژگی‌ها و تکنولوژی‌های استفاده شده

زبان برنامه‌نویسی: C#

معماری نرم‌افزار: Clean Architecture

الگوهای طراحی: SOLID, Dependency Injection

فریمورک: Windows Forms

ابزارها و لایبرری‌ها:

Microsoft.Extensions.DependencyInjection

System.Data برای محاسبات ریاضی


🛠️ نحوه راه‌اندازی پروژه

برای شروع و اجرای پروژه، مراحل ساده زیر رو دنبال کنید:

کد پروژه رو از گیت‌هاب دانلود کنید.

پروژه رو در Visual Studio باز کنید.

پروژه رو اجرا کنید! (خیلی راحت! 😄)


✨ نحوه استفاده

پس از اجرای پروژه، شما یک ماشین‌حساب خواهید داشت که می‌توانید از آن برای انجام عملیات‌های مختلف ریاضی استفاده کنید. رابط کاربری ساده و کاربردی است و شما می‌توانید:

از کیبورد یا دکمه‌های صفحه برای وارد کردن اعداد و عملیات‌ها استفاده کنید.

دکمه ENTER برای محاسبه نتیجه.

دکمه DEL برای پاک کردن ورودی.

دکمه BACK برای حذف یک کاراکتر از ورودی.

دکمه ESCAPE برای خروج از برنامه.


🧑‍💻 کد و ساختار پروژه

پروژه دارای چندین لایه است که هر کدوم مسئولیت خاص خودش رو داره:

لایه Domain: مدل‌ها و مفاهیم اصلی محاسباتی.

لایه Application: عملیات‌ها و پردازش داده‌ها.

لایه UI: رابط کاربری و تعامل با کاربر.


🚨 مشکلات و چالش‌ها

همه چیز همیشه ساده نیست! در این مسیر با چالش‌هایی روبرو شدم:

پیاده‌سازی اصول SOLID و Dependency Injection در ویندوز فرم‌ها کمی پیچیده بود.

مدیریت ورودی‌ها و محاسبات به صورت همزمان نیاز به تفکر دقیق داشت.

مستندسازی و XML Documentation برای کلاس‌ها و متدها یکی از بخش‌های زمان‌بر بود، اما در نهایت نتیجه خوبی داشت.


📚 مستندات و راهنمایی‌ها

تمامی کلاس‌ها و متدهای پروژه به طور کامل مستند شده‌اند و شما می‌توانید از طریق XML Documentation برای درک بهتر عملکرد هر بخش استفاده کنید. این پروژه نه تنها یک ماشین‌حساب ساده است، بلکه به‌عنوان یک تمرین عالی برای معماری نرم‌افزار هم به حساب می‌آید.

🚀 پایان پروژه

این پروژه یک گام مهم در مسیر یادگیری و استفاده از مفاهیم پیشرفته معماری نرم‌افزار بود. به کمک Clean Architecture، SOLID Principles و Dependency Injection، تونستم مفاهیم پیچیده رو در یک پروژه ساده به کار ببرم. امیدوارم این پروژه الهام‌بخش شما باشه تا همیشه با اصول طراحی درست پیش برید و در هر پروژه‌ای، چه بزرگ و چه کوچک، کیفیت رو در اولویت قرار بدید! 🎯
اگر شما هم به این پروژه علاقه‌مندید یا پیشنهادات و نظراتی دارید، خوشحال می‌شم با من در ارتباط باشید .
