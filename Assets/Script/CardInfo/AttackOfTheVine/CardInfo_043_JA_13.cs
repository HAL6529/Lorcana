using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_043_JA_13 : CardInfo
{
    public CardInfo_043_JA_13()
    {
        this.cardNo = "043_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "アブー";
        this.cardName2 = "かしこきサルタン";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.OggyChristiansson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
