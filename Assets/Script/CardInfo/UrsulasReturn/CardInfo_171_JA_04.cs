using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_171_JA_04 : CardInfo
{
    public CardInfo_171_JA_04()
    {
        this.cardNo = "171_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉAÉâÉWÉì";
        this.cardName2 = "óEä∏Ç»ã~èoé“";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RandyBishop;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.ShiftDiscardAnLocationCard };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
