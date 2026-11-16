using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_079_JA_06 : CardInfo
{
    public CardInfo_079_JA_06()
    {
        this.cardNo = "079_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "バジル";
        this.cardName2 = "催眠術にかかったネズミ";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
