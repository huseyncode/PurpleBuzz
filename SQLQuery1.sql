DELETE FROM Services;

INSERT INTO Services (Name, Description, PhotoPath, CreatedDate, Type)
VALUES
    ('Social Media', 'Creating and managing social media campaigns to engage audiences and grow brand presence.', '/assets/img/services-02.jpg', GETDATE(), 'ui graphic'),
    ('Marketing', 'Developing targeted marketing strategies to drive growth and reach new customers.', '/assets/img/services-03.jpg', GETDATE(), 'branding'),
    ('Graphic Design', 'Designing visually appealing graphics and layouts for digital and print media.', '/assets/img/services-04.jpg', GETDATE(), 'ui graphic'),
    ('Digital Marketing', 'Utilizing online platforms to promote brands and products through SEO, ads, and content.', '/assets/img/services-05.jpg', GETDATE(), 'ui graphic'),
    ('Market Research', 'Conducting research to understand market trends, customer needs, and competitive landscape.', '/assets/img/services-06.jpg', GETDATE(), 'branding'),
    ('Business Consulting', 'Providing expert advice to improve business performance and achieve strategic goals.', '/assets/img/services-07.jpg', GETDATE(), 'branding'),
    ('Branding', 'Crafting brand identities that resonate with target audiences and stand out in the market.', '/assets/img/services-08.jpg', GETDATE(), 'ui graphic branding');


	select*from Services