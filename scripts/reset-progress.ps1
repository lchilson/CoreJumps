$ErrorActionPreference = "Stop"

Copy-Item `
    "student/LEARNER-PROGRESS.template.md" `
    "student/LEARNER-PROGRESS.md" `
    -Force

Write-Host "Learner progress reset."
