using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_174_JA_06 : CardInfo
{
    public CardInfo_174_JA_06()
    {
        this.cardNo = "174_JA_06";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "Mr. ビッグ";
        this.cardName2 = "首領ガリネズミ";
        this.power = 1;
        this.toughness = 1;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
