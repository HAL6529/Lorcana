using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_173_JA_08 : CardInfo
{
    public CardInfo_173_JA_08()
    {
        this.cardNo = "173_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ジャンバ博士";
        this.cardName2 = "ネチネチ言う科学者";
        this.power = 1;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Alien, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
