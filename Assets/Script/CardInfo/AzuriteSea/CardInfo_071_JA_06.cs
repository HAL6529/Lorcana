using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_071_JA_06 : CardInfo
{
    public CardInfo_071_JA_06()
    {
        this.cardNo = "071_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "フック船長";
        this.cardName2 = "卑怯な手の使い手";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.TonyBancroftAndLindsayWeyman;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
