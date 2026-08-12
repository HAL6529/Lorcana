using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_173_JA_01 : CardInfo
{
    public CardInfo_173_JA_01()
    {
        this.cardNo = "173_JA_01";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "フック船長";
        this.cardName2 = "ジョリーロジャー号の船長";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = "Adrianne Gumaya";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
