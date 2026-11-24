using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_122_JA_12 : CardInfo
{
    public CardInfo_122_JA_12()
    {
        this.cardNo = "122_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ハートの女王";
        this.cardName2 = "せっかちな旅人";
        this.power = 4;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MagentaMuraca;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Queen};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
