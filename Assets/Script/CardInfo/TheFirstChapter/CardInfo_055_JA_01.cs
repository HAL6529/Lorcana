using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_055_JA_01 : CardInfo
{
    public CardInfo_055_JA_01()
    {
        this.cardNo = "055_JA_01";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "スヴェン";
        this.cardName2 = "王室御用達トナカイ";
        this.power = 5;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = "Jared Nickerl";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
