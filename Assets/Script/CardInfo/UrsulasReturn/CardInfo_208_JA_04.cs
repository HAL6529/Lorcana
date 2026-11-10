using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_208_JA_04 : CardInfo
{
    public CardInfo_208_JA_04()
    {
        this.cardNo = "208_JA_04";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ÉAÅ[ÉXÉâ";
        this.cardName2 = "ëÂäCÇÃñÇèóâ§";
        this.power = 4;
        this.toughness = 7;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.JohnLorenAndNicholasKole;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
