using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_029_JA_10 : CardInfo
{
    public CardInfo_029_JA_10()
    {
        this.cardNo = "029_JA_10";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "首無し騎士の剛速球！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JaimePuga;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheAdventuresOfIchabodAndMrToad;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}
