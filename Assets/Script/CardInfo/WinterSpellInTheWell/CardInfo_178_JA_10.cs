using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_178_JA_10 : CardInfo
{
    public CardInfo_178_JA_10()
    {
        this.cardNo = "178_JA_10";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ニック・ワイルド";
        this.cardName2 = "ずるいキツネの捜査官";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MartaAndreeva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
