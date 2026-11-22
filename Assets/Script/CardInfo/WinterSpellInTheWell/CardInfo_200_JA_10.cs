using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_200_JA_10 : CardInfo
{
    public CardInfo_200_JA_10()
    {
        this.cardNo = "200_JA_10";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ヘラクレスの剣";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KamilMurzyn;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
