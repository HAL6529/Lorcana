using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_065_JA_13 : CardInfo
{
    public CardInfo_065_JA_13()
    {
        this.cardNo = "065_JA_13";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "WITH A FEW GOOD FRIENDS";
        this.cardName2 = "ウィズ・ア・フュー・グッド・フレンズ";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether6 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}
