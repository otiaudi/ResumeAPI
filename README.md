# Resume Extractor API

## Project Overview
The Resume Extractor API is a .NET Core Web API designed to extract key information from resumes in PDF or Word format. Extracted information includes:
- Candidate Name
- Phone Number
- Links (e.g., GitHub, LinkedIn)
- Work Experience (Company Name, Dates, Role)
- Education Background (School Name, Year, Major/Study)
- Skills

The extracted data is stored in a MySQL database for further use.

---

## Features
1. **File Upload**: Accepts PDF and Word documents for processing.
2. **Data Extraction**: Uses libraries to parse the documents and extract relevant fields.
3. **Database Storage**: Stores extracted data in a structured MySQL database.
4. **API Endpoints**: Exposes RESTful endpoints for uploading resumes and retrieving extracted data.

---

## Technologies Used
- **Programming Language**: C#
- **Framework**: .NET Core Web API
- **Database**: MySQL
- **Libraries**:
  - TikaOnDotNet (for text extraction)
  - DocumentFormat.OpenXml (for Word document parsing)
- **Tools**:
  - Entity Framework Core (for ORM and migrations)

---

## Prerequisites
1. .NET SDK (6.0 or later)
2. MySQL Server (8.0 or later)
3. IDE/Text Editor (e.g., Visual Studio, Visual Studio Code)
4. Postman or similar tool for API testing

---

## Installation
### Step 1: Clone the Repository
```bash
# Clone the repository
git clone https://github.com/your-repo/resume-extractor-api.git
cd resume-extractor-api
```

### Step 2: Install Dependencies
Restore the required NuGet packages:
```bash
dotnet restore
```

### Step 3: Configure Database
1. Open `appsettings.json`.
2. Update the `DefaultConnection` string with your MySQL credentials:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=ResumeDB;User=root;Password=yourpassword;"
     }
   }
   ```

### Step 4: Apply Database Migrations
Run the following commands to create and initialize the database:
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### Step 5: Run the API
Start the application:
```bash
dotnet run
```

The API will run at `http://localhost:5000` (or a different port if specified).

---

## File Structure
```
ResumeExtractorAPI/
├── Controllers/
│   └── ResumeController.cs
├── Data/
│   └── AppDbContext.cs
├── Models/
│   ├── Resume.cs
│   ├── WorkExperience.cs
│   └── EducationBackground.cs
├── Properties/
├── appsettings.json
├── Program.cs
├── ResumeExtractorAPI.csproj
└── README.md
```

---

## API Endpoints
### Upload Resume
**POST** `/api/resumes/upload`
- **Description**: Upload a PDF or Word document for processing.
- **Request**: Multipart form data with file.
- **Response**:
  ```json
  {
    "success": true,
    "message": "Resume processed successfully."
  }
  ```

### Get All Resumes
**GET** `/api/resumes`
- **Description**: Retrieve all resumes stored in the database.
- **Response**:
  ```json
  [
    {
      "id": 1,
      "candidateName": "John Doe",
      "phoneNumber": "1234567890",
      "links": "https://github.com/johndoe",
      "workExperiences": [
        {
          "companyName": "Tech Corp",
          "role": "Software Developer",
          "dates": "Jan 2020 - Dec 2021"
        }
      ],
      "educationBackgrounds": [
        {
          "schoolName": "XYZ University",
          "major": "Computer Science",
          "year": "2016 - 2020"
        }
      ],
      "skills": "C#, .NET, SQL"
    }
  ]
  ```

---

## Testing the API
1. Use Postman or any API testing tool.
2. Upload a resume via the `/api/resumes/upload` endpoint.
3. Verify the extracted data by calling the `/api/resumes` endpoint.

---

## Contributing
1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature-name
   ```
3. Commit your changes:
   ```bash
   git commit -m "Added new feature"
   ```
4. Push to your branch:
   ```bash
   git push origin feature-name
   ```
5. Open a pull request.

---

## License
This project is licensed under the MIT License. See the LICENSE file for details.

---

## Contact
For any inquiries or issues, please contact:
- **Name**: Silas Odero
- **Email**: silasodero2020@gmail.com


