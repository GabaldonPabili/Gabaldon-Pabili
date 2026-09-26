:root {
  /* Soothing Green Palette */
  --green-light: #e8f5e9;
  --green-primary: #4caf50;
  --green-dark: #2e7d32;
  --bg-color: #ffffff; /* Ginawang pure white para seamless ang blend */
  --card-bg: #ffffff;
  --text-main: #1b241b;
  --text-muted: #5c6b5c;
  --btn-text: #ffffff;
  
  --font-main: 'Plus Jakarta Sans', sans-serif;
}

/* Updated Hero Section na may Green to White Gradient */
.hero {
  /* Nagbe-blend mula dark green sa taas, pa-light green sa gitna, hanggang puti sa ibaba */
  background: linear-gradient(180deg, var(--green-dark) 0%, var(--green-primary) 60%, #ffffff 100%);
  padding: 120px 0 80px;
  color: var(--card-bg);
  overflow: hidden;
}

/* Nagdagdag ng light shadow para mabasa pa rin ang text kahit pumusyaw ang background */
.hero-text h1 {
  font-size: clamp(32px, 4vw, 48px);
  line-height: 1.2;
  margin-bottom: 20px;
  text-shadow: 0 2px 8px rgba(0, 0, 0, 0.15);
}

.hero-text p {
  font-size: 16px;
  line-height: 1.6;
  margin-bottom: 30px;
  color: #f7fbf7;
  text-shadow: 0 1px 4px rgba(0, 0, 0, 0.15);
}