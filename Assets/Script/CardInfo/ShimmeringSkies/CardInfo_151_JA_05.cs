using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_151_JA_05 : CardInfo
{
    public CardInfo_151_JA_05()
    {
        this.cardNo = "151_JA_05";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ルードヴィヒ・フォン・ドレイク";
        this.cardName2 = "自称・天才";
        this.power = 4;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.MattChapman;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
