using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_104_JA_02 : CardInfo
{
    public CardInfo_104_JA_02()
    {
        this.cardNo = "104_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉuÅ[Éì";
        this.cardName2 = "ëÅènÇ»é¿ã∆â∆";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
