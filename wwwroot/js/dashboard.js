// Real-time Date & Time Update
function updateDateTime() {
    const now = new Date();
    const options = {
        year: 'numeric',
        month: 'long',
        day: 'numeric',
        hour: '2-digit',
        minute: '2-digit',
        second: '2-digit',
        hour12: true,
        timeZone: 'Asia/Kolkata'
    };
    
    const formatter = new Intl.DateTimeFormat('en-IN', options);
    const dateTimeString = formatter.format(now);
    
    const element = document.getElementById('currentDateTime');
    if (element) {
        element.textContent = dateTimeString;
    }
}

// Update immediately and every second
updateDateTime();
setInterval(updateDateTime, 1000);

// Smooth animations on load
document.addEventListener('DOMContentLoaded', function() {
    const cards = document.querySelectorAll('.bg-slate-700');
    cards.forEach((card, index) => {
        card.style.opacity = '0';
        card.style.transform = 'translateY(20px)';
        
        setTimeout(() => {
            card.style.transition = 'all 0.5s ease';
            card.style.opacity = '1';
            card.style.transform = 'translateY(0)';
        }, index * 100);
    });
});