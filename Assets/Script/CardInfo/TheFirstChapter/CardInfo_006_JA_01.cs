using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_006_JA_01 : CardInfo
{
    public CardInfo_006_JA_01()
    {
        this.cardNo = "006_JA_01";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ƒnƒfƒX";
        this.cardName2 = "–»ŠE‚ÌŽå";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Randy Bishop";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
