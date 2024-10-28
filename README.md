Варіант - 13 (Патерн "Фасад"):

Фасад — це структурний патерн проектування, який надає спрощений інтерфейс для взаємодії з великою системою класів. Він об'єднує кілька методів або компонентів у єдиному класі, приховуючи складну внутрішню реалізацію. Клієнт може працювати з системою через простий інтерфейс, не заглиблюючись у деталі її структури, що спрощує інтеграцію та підвищує зручність використання.

Застосування:
1. Якщо в системі багато класів, фасад зможе об’єднати потрібні методи в одному класі, щоб зробити роботу з системою інтуїтивно зрозумілою.
2. Якщо система поділена на різні рівні чи підсистеми, фасад може створити окремий інтерфейс для кожного рівня.

Реалізація:  
Створюється клас фасаду, який містить посилання на підсистеми і надає методи для їх використання

**Нижче прикріпляю UML-діаграму до завдання 2**


![image](https://github.com/user-attachments/assets/a5de1d32-7422-43bb-a83a-a7e9fafd42e8)
