using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_175_JA_10 : CardInfo
{
    public CardInfo_175_JA_10()
    {
        this.cardNo = "175_JA_10";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "クロウハウザー";
        this.cardName2 = "ドーナツ好きの警官";
        this.power = 5;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SGeer;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
