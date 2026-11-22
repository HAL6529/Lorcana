using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_239_JA_10 : CardInfo
{
    public CardInfo_239_JA_10()
    {
        this.cardNo = "239_JA_10";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ニック・ワイルドニック・ワイルド";
        this.cardName2 = "不屈の捜査官";
        this.power = 5;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SlawomirManiak;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Ally, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
