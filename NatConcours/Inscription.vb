Imports System.IO

Module Inscription
	'Structure d'un candidat inscrit
	Public Structure Candidat
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

	'Liste des candidats et compteur numéro candidat le plus haut actuelle
	Dim candidatsInscrits = New List(Of Candidat)
	Dim compteur As Integer = 1

	'permet d'inscrire un candidat
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
	'permet d'inscrire un candidat surcharge
	Public Sub InscrireCandidat(Numéro As Integer, Nom As String, Prénom As String, Age As Integer, Adresse As String, CodePostal As String, Ville As String, Region As String, MatièreOral() As String, MatièreEcrit() As String, MatièreOption As String)
		Dim temp As Candidat
		temp.Numéro = Numéro
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
	'permet d'inscrire un candidat surcharge
	Public Sub InscrireCandidat(temp As Candidat)
		candidatsInscrits.Add(temp)
	End Sub
	'permet de supprimer un candidat
	Public Sub SupprimerCandidat(num As Integer)
		candidatsInscrits.remove(candidatsInscrits(num))
	End Sub
	'permet de récuperer des informations d'un candidat avec son numéro
	Public Function getCandidat(num As Integer)
		Return candidatsInscrits(num)
	End Function

	'permet d'enregistrer dans un fichier les inscriptions
	Public Sub EnregistrerInscrits()

		Dim f As New StreamWriter("NatConcours\Candidats.txt")
		For Each candidat As Candidat In candidatsInscrits
			f.WriteLine("Candidat numéro: " + CStr(candidat.Numéro))
			f.WriteLine(candidat.Prénom + " " + candidat.Nom + " " + CStr(candidat.Age) + " Ans")
			f.WriteLine(candidat.Adresse)
			f.WriteLine(candidat.CodePostal + " " + candidat.Ville)
			f.WriteLine("Région de passage des épreuves: " + candidat.Region)
			Dim matEcrite As String = ""
			Dim cpt As Integer = 0
			'On affiche ses matière ecrites
			For Each mat As String In candidat.MatièreEcrit
				If cpt < candidat.MatièreEcrit.Length - 1 Then
					matEcrite = matEcrite + mat + ", "
				Else
					matEcrite = matEcrite + mat
				End If
				cpt = cpt + 1
			Next
			f.WriteLine("Ecrits: " + matEcrite)
			Dim matOral As String = ""
			cpt = 0
			'On affiche ses oraux
			For Each mat As String In candidat.MatièreOral
				If cpt < candidat.MatièreOral.Length - 1 Then
					matOral = matOral + mat + ", "
				Else
					matOral = matOral + mat
				End If
				cpt = cpt + 1
			Next
			'On affiche ses options
			f.WriteLine("Oraux: " + matOral)
			If Len(candidat.MatièreOption) > 0 Then
				f.WriteLine("Option: " + candidat.MatièreOption)
			Else
				f.WriteLine("Option: Aucune")
			End If
			f.WriteLine()
		Next

		If line Then
			f.WriteLine("Inscriptions cloturés")
		End If

		f.Close()
	End Sub

	Public line As Boolean = False

	'permet de lire le fichier avec les inscrits
	Public Sub OuvrirInscrits()

		Dim temp As Candidat

		Dim objStreamReader As StreamReader
		Try
			MkDir("NatConcours\")
			MkDir("NatConcours\Listing épreuve\")
		Catch ex As Exception

		End Try
		Try
			objStreamReader = New StreamReader("NatConcours\Candidats.txt")
		Catch ex As Exception
			Dim f As New StreamWriter("NatConcours\Candidats.txt")
			f.Close()
			objStreamReader = New StreamReader("NatConcours\Candidats.txt")
		End Try

		'Numéro
		Dim temNum As String = objStreamReader.ReadLine

		Do While Not temNum Is Nothing

			If temNum = "Inscriptions cloturés" Then
				line = True
				objStreamReader.Close()
				Accueil.ButtonRecommencer.Visible = True
				Exit Sub
			End If


			If CInt(Mid(temNum, 18)) + 1 > compteur Then
				compteur = CInt(Mid(temNum, 18)) + 1
			End If

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

		'permet d'avoir le nombre de candidat actuellement
		Return candidatsInscrits.Count()
	End Function

	'permet d'avoir le numéro du dernier inscrit
	Public Function getNumDernierInscrit()
		Return candidatsInscrits(candidatsInscrits.Count() - 1).Numéro
	End Function


	Public Sub Listing()
		Try
			MkDir("NatConcours\Listing épreuve\")

		Catch ex As Exception

		End Try
		Dim tabMatière() As String = {"Algorithmique", "Base de données", "Droit", "Expression",
"Gestion", "Langage C", "Langage Java", "Mathématiques",
"Programmation web", "Réseau", "Système", "Visual Basic .NET", "Anglais", "Chinois", "Espagnol"}
		For Each Matière As String In tabMatière
			'On tri par région , nom ,prénom
			Dim tab(getNombreCandidat()) As String
			For i = 0 To getNombreCandidat() - 1
				tab(i) = getCandidat(i).Region + " " + getCandidat(i).Nom + " " + getCandidat(i).Prénom + " " + CStr(getCandidat(i).Numéro)
			Next
			Array.Sort(tab)
			'On récupère le tri et on l'inject dans l'ordre dans les textbox
			For i = 0 To getNombreCandidat() - 1
				Dim Splitage As String()
				Splitage = Split(tab(i + 1))
				Dim Num As Integer = CInt(Splitage(Splitage.Length - 1))
				'récupération du candidat
				For j = 0 To getNombreCandidat() - 1
					If getCandidat(j).Numéro = Num Then
						Num = j
						Exit For
					End If
				Next
				'On regarde si il a la matière
				Dim oui As Boolean = False
				Dim ouioral As Boolean = False
				For Each oral As String In getCandidat(Num).MatièreEcrit()
					If oral = Matière Then
						oui = True

					End If
				Next
				For Each oral As String In getCandidat(Num).MatièreOral()
					If oral = Matière Then
						oui = True
						ouioral = True
					End If
				Next
				If getCandidat(Num).MatièreOption = Matière Then
					oui = True
					ouioral = True
				End If
				'On injecte dans les listboxs
				If oui Then
					Dim objStreamReader As StreamReader
					Dim name As String = "NatConcours\Listing épreuve\" + Matière + "_" + getCandidat(Num).Region + ".txt"
					Try
						objStreamReader = New StreamReader(name)
						objStreamReader.Close()

					Catch ex As Exception
						Dim f As New StreamWriter(name)
						f.Close()
					End Try
					Dim inputString As String = getCandidat(Num).Nom + " " + getCandidat(Num).Prénom + " " + CStr(getCandidat(Num).Numéro) + Chr(13) + Chr(10)

					If ouioral Then
						inputString = getCandidat(Num).Nom + " " + getCandidat(Num).Prénom + " " + CStr(getCandidat(Num).Numéro) + "*" + Chr(13) + Chr(10)
					End If

					My.Computer.FileSystem.WriteAllText(name, inputString, True)

				End If

			Next
		Next

	End Sub

	Public Sub Reset()
		Dim FileToDelete As String = "NatConcours\Candidats.txt"
		If System.IO.File.Exists(FileToDelete) = True Then
			System.IO.File.Delete(FileToDelete)
		End If


		Dim tabMatière() As String = {"Algorithmique", "Base de données", "Droit", "Expression",
"Gestion", "Langage C", "Langage Java", "Mathématiques",
"Programmation web", "Réseau", "Système", "Visual Basic .NET", "Anglais", "Chinois", "Espagnol"}
		For Each Matière As String In tabMatière

			For i = 0 To getNombreCandidat() - 1

				'On regarde si il a la matière
				Dim oui As Boolean = False
				Dim ouioral As Boolean = False
				For Each oral As String In getCandidat(i).MatièreEcrit()
					If oral = Matière Then
						oui = True

					End If
				Next
				For Each oral As String In getCandidat(i).MatièreOral()
					If oral = Matière Then
						oui = True
						ouioral = True
					End If
				Next
				If getCandidat(i).MatièreOption = Matière Then
					oui = True
					ouioral = True
				End If
				'On injecte dans les listboxs
				If oui Then
					Dim objStreamReader As StreamReader
					Dim FileToDelete2 As String = "NatConcours\Listing épreuve\" + Matière + "_" + getCandidat(i).Region + ".txt"
					If System.IO.File.Exists(FileToDelete2) = True Then
						System.IO.File.Delete(FileToDelete2)
					End If

				End If

			Next
		Next


	End Sub

End Module
