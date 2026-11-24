using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_145_JA_12 : CardInfo
{
    public CardInfo_145_JA_12()
    {
        this.cardNo = "145_JA_12";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ガジェット・ハックレンチ";
        this.cardName2 = "工夫上手なメカニック";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaxUlichney;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Inventor};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
