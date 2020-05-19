Imports System.IO

Module Inscription
	Private Structure Candidat
		Public Numéro As Integer
		Public Nom As String
		Public Prénom As String
		Public Age As Integer
		Public Adresse As String
		Public CodePostal As String
		Public Ville As String
		Public Region As String
		Public MatièreOral() As String
		Public MatièreEcrit() As String
		Public MatièreOption As String
	End Structure

	Dim candidatsInscrits = New List(Of Candidat)
	Dim compteur As Integer = 1

	Public Sub InscrireCandidat(Nom As String, Prénom As String, Age As Integer, Adresse As String, CodePostal As String, Ville As String, Region As String, MatièreOral() As String, MatièreEcrit() As String, MatièreOption As String)
		Dim temp As Candidat
		temp.Numéro = compteur
		compteur = compteur + 1
		temp.Nom = Nom
		temp.Prénom = Prénom
		temp.Age = Age
		temp.Adresse = Adresse
		temp.CodePostal = CodePostal
		temp.Ville = Ville
		temp.Region = Region
		temp.MatièreOral = MatièreOral
		temp.MatièreEcrit = MatièreEcrit
		temp.MatièreOption = MatièreOption
		candidatsInscrits.Add(temp)
	End Sub
	Private Sub InscrireCandidat(temp As Candidat)
		candidatsInscrits.Add(temp)
	End Sub

	Public Function getCandidat(num As Integer)
		Return candidatsInscrits(num)
	End Function

	Public Sub EnregistrerInscrits()
		Dim MatièreOral2() As String = {"Langage C", "Droit", "Expression"}
		Dim MatièreEcrit2() As String = {"Langage Java", "Algorithmique", "Droit", "Expression"}
		Try
			MkDir("NatConcours\")
			MkDir("NatConcours\Listing épreuve\")
		Catch ex As Exception
			'fichier existe déjà
		End Try
		Dim compteur2 As Integer = 0

		Dim f As New StreamWriter("NatConcours\Candidats.txt")
		For Each candidat As Candidat In candidatsInscrits
			compteur2 = compteur + 1
			f.WriteLine("Candidat numéro: " + CStr(candidat.Numéro))
			f.WriteLine(candidat.Prénom + " " + candidat.Nom + " " + CStr(candidat.Age) + " Ans")
			f.WriteLine(candidat.Adresse)
			f.WriteLine(candidat.CodePostal + " " + candidat.Ville)
			f.WriteLine("Région de passage des épreuves: " + candidat.Region)
			Dim matEcrite As String = ""
			Dim cpt As Integer = 0
			For Each mat As String In candidat.MatièreEcrit
				If cpt < 3 Then
					matEcrite = matEcrite + mat + ", "
				Else
					matEcrite = matEcrite + mat
				End If
				cpt = cpt + 1
			Next
			f.WriteLine("Ecrits: " + matEcrite)
			Dim matOral As String = ""
			cpt = 0
			For Each mat As String In candidat.MatièreOral
				If cpt < 2 Then
					matOral = matOral + mat + ", "
				Else
					matOral = matOral + mat
				End If
				cpt = cpt + 1
			Next
			f.WriteLine("Oraux: " + matOral)
			If Len(candidat.MatièreOption) > 0 Then
				f.WriteLine("Option: " + candidat.MatièreOption)
			Else
				f.WriteLine("Option: Aucune")
			End If
			f.WriteLine()
		Next
		f.Close()
	End Sub

	Public Sub EnregistrerListing()

	End Sub

	Public Sub OuvrirInscrits()

		Dim temp As Candidat

		Dim objStreamReader As StreamReader
		'Dim strLine As String

		objStreamReader = New StreamReader("NatConcours\Candidats.txt")
		'Numéro
		Dim temNum As String = objStreamReader.ReadLine

		Do While Not temNum Is Nothing

			temp.Numéro = CInt(Mid(temNum, 18))
			'Prénom, nom, Age
			Dim tabPrénomNomAge As String()
			Dim stPrénomNomAge As String = objStreamReader.ReadLine
			tabPrénomNomAge = Split(stPrénomNomAge)
			temp.Prénom = tabPrénomNomAge(0)
			temp.Nom = tabPrénomNomAge(1)
			temp.Age = tabPrénomNomAge(2)
			'Adresse
			temp.Adresse = objStreamReader.ReadLine
			'Code postal, Ville
			Dim stCPVille As String = objStreamReader.ReadLine
			temp.CodePostal = Mid(stCPVille, 1, 5)
			temp.Ville = Mid(stCPVille, 7)
			'Region passage
			Dim temRegion As String = objStreamReader.ReadLine
			temp.Region = Mid(temRegion, 33)
			'Ecrits

			Dim stEcrits As String = objStreamReader.ReadLine
			Dim tabEcrits As String()
			Dim stTempEcrit As String = ""
			Dim EcritsTemp(4) As String
			Dim cptEcrits As Integer = 0
			tabEcrits = Split(stEcrits)
			tabEcrits(tabEcrits.Length - 1) = tabEcrits(tabEcrits.Length - 1) + ","
			For Each item As String In tabEcrits
				If (item = "Ecrits:") Then
				Else
					If Right(item, 1) = "," Then
						EcritsTemp(cptEcrits) = stTempEcrit + Mid(item, 1, Len(item) - 1)
						stTempEcrit = ""
						cptEcrits = cptEcrits + 1
					Else
						If stTempEcrit = "" Then
							stTempEcrit = item + " "
						Else
							stTempEcrit = stTempEcrit + item + " "
						End If
					End If
				End If
			Next
			temp.MatièreEcrit = EcritsTemp

			'Oraux
			Dim stOraux As String = objStreamReader.ReadLine
			Dim tabOraux As String()
			Dim stTempOraux As String = ""
			Dim OrauxTemp(3) As String
			Dim cptOraux As Integer = 0
			tabOraux = Split(stOraux)
			tabOraux(tabOraux.Length - 1) = tabOraux(tabOraux.Length - 1) + ","
			For Each item As String In tabOraux
				If (item = "Oraux:") Then
				Else
					If Right(item, 1) = "," Then
						OrauxTemp(cptOraux) = stTempOraux + Mid(item, 1, Len(item) - 1)
						stTempOraux = ""
						cptOraux = cptOraux + 1
					Else
						If stTempOraux = "" Then
							stTempOraux = item + " "
						Else
							stTempOraux = stTempOraux + item + " "
						End If
					End If
				End If
			Next
			temp.MatièreOral = OrauxTemp
			'Option
			Dim stOption As String = objStreamReader.ReadLine
			If Mid(stOption, 8) = "Aucune" Then
				temp.MatièreOption = ""
			Else
				temp.MatièreOption = Mid(stOption, 9)
			End If
			objStreamReader.ReadLine()
			InscrireCandidat(temp)

			temNum = objStreamReader.ReadLine
		Loop

		objStreamReader.Close()
	End Sub

	Public Function getNombreCandidat()
		Return candidatsInscrits.Count()
	End Function

End Module
