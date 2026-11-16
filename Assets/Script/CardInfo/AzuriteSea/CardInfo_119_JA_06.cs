using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_119_JA_06 : CardInfo
{
    public CardInfo_119_JA_06()
    {
        this.cardNo = "119_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アラジン";
        this.cardName2 = "大胆不敵な指揮官";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift2 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
